namespace Machete
{
    using System;
    using System.Text;
    using Texts;


    /// <summary>
    /// Text which can be parsed, backed by a variety of implementations optimized to avoid
    /// memory copies.
    /// </summary>
    public abstract class ParseText
    {
        /// <summary>
        /// Return the character at the specified position
        /// </summary>
        public abstract char this[int position] { get; }

        /// <summary>
        /// The text length
        /// </summary>
        public abstract int Length { get; }

        /// <summary>
        /// Returns the string for the <paramref name="span"/>.
        /// </summary>
        public virtual string ToString(TextSpan span)
        {
            var builder = new StringBuilder();

            AppendTo(builder, span);

            return builder.ToString();
        }

        /// <summary>
        /// Copy the source text to the destination character array
        /// </summary>
        /// <param name="sourceIndex">The start index into the source text</param>
        /// <param name="destination">The destination character array</param>
        /// <param name="destinationIndex">The start index of the destination array</param>
        /// <param name="count">The number of characters to copy</param>
        public abstract void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);

        /// <summary>
        /// An empty <see cref="ParseText"/>.
        /// </summary>
        public static readonly ParseText Empty = new EmptyText();

        /// <summary>
        /// Append the <paramref name="span"/> to the <see cref="StringBuilder"/>.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="span"></param>
        public virtual void AppendTo(StringBuilder builder, TextSpan span)
        {
            CheckSpanInLength(span);

            var buffer = new char[Math.Min(span.Length, 1024)];

            int position = Math.Max(Math.Min(span.Start, Length), 0);
            int length = Math.Min(span.End, Length) - position;

            while (position < Length && length > 0)
            {
                int copyLength = Math.Min(buffer.Length, length);
                CopyTo(position, buffer, 0, copyLength);
                builder.Append(buffer, 0, copyLength);
                length -= copyLength;
                position += copyLength;
            }
        }

        public abstract int Compare(string comparator, int index, TextSpan span, StringComparison comparison);

        /// <summary>
        /// Returns the index of the first instance of the specified value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="span"></param>
        /// <returns></returns>
        public virtual int IndexOf(char value, TextSpan span)
        {
            CheckSpanInLength(span);

            for (int i = span.Start; i < span.End; i++)
            {
                if (this[i] == value)
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// Returns the <see cref="ParseText"/> for the specified <paramref name="span"/>.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public virtual ParseText GetSubText(TextSpan span)
        {
            CheckSpanInLength(span);

            int spanLength = span.Length;
            if (spanLength == 0)
                return Empty;

            if (spanLength == Length && span.Start == 0)
                return this;

            return new SubText(this, span);
        }

        /// <summary>
        /// Uses the span-based virtual member to convert ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ToString(new TextSpan(0, Length));
        }

        /// <summary>
        /// Returns the <see cref="ParseText"/> starting with the specified index
        /// </summary>
        /// <param name="start">The starting text index</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public ParseText GetSubText(int start)
        {
            if (start < 0 || start > Length)
                throw new ArgumentOutOfRangeException(nameof(start));

            if (start == 0)
                return this;

            if (start == Length)
                return Empty;

            return GetSubText(new TextSpan(start, Length - start));
        }

        /// <summary>
        /// Verifies that the span is within the source text
        /// </summary>
        /// <param name="span"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        protected void CheckSpanInLength(TextSpan span)
        {
            if (span.Start < 0 || span.Start > Length || span.End > Length)
                throw new ArgumentOutOfRangeException(nameof(span));
        }
    }
}