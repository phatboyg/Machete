namespace Machete.Texts
{
    using System;
    using System.Text;


    /// <summary>
    /// This is purely empty text, and can be reused by anything
    /// </summary>
    public class EmptyText :
        ParseText
    {
        public override char this[int position] => throw new ArgumentOutOfRangeException(nameof(position));

        public override int Length => 0;

        public override string ToString(TextSpan span)
        {
            CheckSpanInLength(span);

            return string.Empty;
        }

        public override void CopyTo(int startIndex, char[] destination, int destinationIndex, int count)
        {
            if (count != 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            
            if (startIndex != 0)
                throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        public override void AppendTo(StringBuilder builder, TextSpan span)
        {
            CheckSpanInLength(span);
        }

        public override int Compare(string comparator, int index, TextSpan span, StringComparison comparison)
        {
            return string.Compare(comparator, index, string.Empty, 0, 0, comparison);
        }
    }
}