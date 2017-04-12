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

            return obj is TextSpan && Equals((TextSpan)obj);
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

        public int Start { get; }

        public int End => Start + Length;

        public int Length { get; }

        public bool IsEmpty => Length == 0;

        public bool Contains(int index)
        {
            return unchecked((uint)(index - Start) < (uint)Length);
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
                : (TextSpan?)null;
        }

        public bool IntersectsWith(TextSpan span)
        {
            return span.Start <= End && span.End >= Start;
        }

        public bool IntersectsWith(int position)
        {
            return unchecked((uint)(position - Start) <= (uint)Length);
        }

        public TextSpan? Intersection(TextSpan span)
        {
            int intersectStart = Math.Max(Start, span.Start);
            int intersectEnd = Math.Min(End, span.End);

            return intersectStart <= intersectEnd
                ? FromBounds(intersectStart, intersectEnd)
                : (TextSpan?)null;
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
    }
}