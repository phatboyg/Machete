namespace Machete.Texts
{
    using System;
    using System.Diagnostics;
    using System.Text;


    /// <summary>
    /// A string-backed source text
    /// </summary>
    public class StringText :
        ParseText
    {
        readonly string _text;

        public StringText(string text)
        {
            Debug.Assert(text != null);

            _text = text;
        }

        public override int Length => _text.Length;

        public override char this[int position] => _text[position];

        public override string ToString(TextSpan span)
        {
            if (span.Start == 0)
            {
                if (span.Length == _text.Length)
                    return _text;
                if (span.Length == 0)
                    return string.Empty;
            }

            return _text.Substring(span.Start, span.Length);
        }

        public override void CopyTo(int startIndex, char[] destination, int destinationIndex, int count)
        {
            _text.CopyTo(startIndex, destination, destinationIndex, count);
        }

        public override void AppendTo(StringBuilder builder, TextSpan span)
        {
            if (span.Start == 0 && span.Length == _text.Length)
            {
                builder.Append(_text);
            }
            else
            {
                builder.Append(_text, span.Start, span.Length);
            }
        }

        public override int Compare(string comparator, int index, TextSpan span, StringComparison comparison)
        {
            return string.Compare(comparator, index, _text, span.Start, span.Length, comparison);
        }

        public override int IndexOf(char value, TextSpan span)
        {
            return _text.IndexOf(value, span.Start, span.Length);
        }
    }
}