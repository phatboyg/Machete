namespace Machete
{
    using System;
    using System.Diagnostics;


    /// <summary>
    /// A span of text
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebugDisplay) + "}")]
    public struct TextSpan :
        IEquatable<TextSpan>,
        IComparable<TextSpan>
    {
        public TextSpan(int start, int length)
        {
            Debug.Assert(start >= 0);
            Debug.Assert(start + length >= start);

            Start = start;
            Length = length;
        }

        public bool Equals(TextSpan other)
        {
            return Start == other.Start && Length == other.Length;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;

            return obj is TextSpan span && Equals(span);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Start * 397) ^ Length;
            }
        }

        public int CompareTo(TextSpan other)
        {
            var diff = Start - other.Start;
            if (diff != 0)
            {
                return diff;
            }

            return Length - other.Length;
        }

        public bool IsAdjacentTo(TextSpan other)
        {
            return Start + Length == other.Start || other.Start + other.Length == Start;
        }

        /// <summary>
        /// An empty TextSpan at the End of the TextSpan
        /// </summary>
        public TextSpan Tail => FromBounds(End, End);

        /// <summary>
        /// An empty TextSpan at the Start of the TextSpan
        /// </summary>
        public TextSpan Head => FromBounds(Start, Start);

        /// <summary>
        /// Combines the two text spans, if they are adjacent, into a single text span
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static TextSpan operator +(TextSpan left, TextSpan right)
        {
            if (left.Start + left.Length == right.Start)
                return new TextSpan(left.Start, left.Length + right.Length);
            
            if (right.Start + right.Length == left.Start)
                return new TextSpan(right.Start, right.Length + left.Length);

            throw new ArgumentException("The text spans must be adjacent to be combined");
        }

        public int Start { get; }

        public int End => Start + Length;

        public int Length { get; }

        public bool IsEmpty => Length == 0;

        public bool Contains(int index)
        {
            return unchecked((uint) (index - Start) < (uint) Length);
        }

        public bool Contains(TextSpan span)
        {
            return span.Start >= Start && span.End <= End;
        }

        public bool OverlapsWith(TextSpan span)
        {
            int overlapStart = Math.Max(Start, span.Start);
            int overlapEnd = Math.Min(End, span.End);

            return overlapStart < overlapEnd;
        }

        public TextSpan? Overlap(TextSpan span)
        {
            int overlapStart = Math.Max(Start, span.Start);
            int overlapEnd = Math.Min(End, span.End);

            return overlapStart < overlapEnd
                ? FromBounds(overlapStart, overlapEnd)
                : (TextSpan?) null;
        }

        public bool IntersectsWith(TextSpan span)
        {
            return span.Start <= End && span.End >= Start;
        }

        public bool IntersectsWith(int position)
        {
            return unchecked((uint) (position - Start) <= (uint) Length);
        }

        public TextSpan? Intersection(TextSpan span)
        {
            int intersectStart = Math.Max(Start, span.Start);
            int intersectEnd = Math.Min(End, span.End);

            return intersectStart <= intersectEnd
                ? FromBounds(intersectStart, intersectEnd)
                : (TextSpan?) null;
        }

        public static TextSpan FromBounds(int start, int end)
        {
            if (start < 0)
                throw new ArgumentOutOfRangeException(nameof(start));

            if (end < start)
                throw new ArgumentOutOfRangeException(nameof(end));

            return new TextSpan(start, end - start);
        }

        public static bool operator ==(TextSpan left, TextSpan right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TextSpan left, TextSpan right)
        {
            return !left.Equals(right);
        }

        string DebugDisplay => $"TextSpan (Start: {Start}, End: {End}, Length: {Length})";

        public static readonly TextSpan Empty = new TextSpan(0, 0);

        public override string ToString()
        {
            return $"TextSpan ({Start}..{End}, {Length})";
        }

        public TextSpan Skip(int count)
        {
            if (count > Length)
                throw new ArgumentOutOfRangeException(nameof(count));

            return FromBounds(Start + count, End);
        }

        /// <summary>
        /// Returns a TextSpan for the first character
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public TextSpan First
        {
            get
            {
                if (Length <= 0)
                    throw new InvalidOperationException($"The TextSpan is empty");

                return new TextSpan(Start, 1);
            }
        }

        public TextSpan Take(int count)
        {
            if (count > Length)
                throw new ArgumentOutOfRangeException(nameof(count), $"The specified count ({count}) was past the end: {this}");

            return new TextSpan(Start, count);
        }
    }
}