namespace Machete.Texts
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using System.Text.RegularExpressions;


    /// <summary>
    /// A virtual <see cref="ParseText"/> based off the original, with a span applied to it.
    /// </summary>
    public class SubText :
        ParseText
    {
        readonly ParseText _text;
        readonly TextSpan _span;

        public SubText(ParseText text, TextSpan span)
        {
            Debug.Assert(text != null, "text != null");
            Debug.Assert(span.Start <= text.Length, "span.Start <= text.Length");
            Debug.Assert(span.Start + span.Length <= text.Length, "span.Start + span.Length <= text.Length");

            _text = text;
            _span = span;
        }

        public override int Length => _span.Length;

        public override char this[int position]
        {
            get
            {
                if (position < 0 || position > Length)
                    throw new ArgumentOutOfRangeException(nameof(position));

                return _text[_span.Start + position];
            }
        }

        public override string ToString(TextSpan span)
        {
            CheckSpanInLength(span);

            return _text.ToString(GetCompositeSpan(span.Start, span.Length));
        }

        public override void AppendTo(StringBuilder builder, TextSpan span)
        {
            CheckSpanInLength(span);

            _text.AppendTo(builder, GetCompositeSpan(span.Start, span.Length));
        }

        public override int Compare(string comparator, int index, TextSpan span, StringComparison comparison)
        {
            CheckSpanInLength(span);

            return _text.Compare(comparator, index, new TextSpan(_span.Start + span.Start, span.Length), comparison);
        }

        public override ParseText GetSubText(TextSpan span)
        {
            CheckSpanInLength(span);

            return new SubText(_text, GetCompositeSpan(span.Start, span.Length));
        }

        public override Match Match(Regex regex, TextSpan span)
        {
            CheckSpanInLength(span);

            return _text.Match(regex, new TextSpan(_span.Start + span.Start, span.Length));
        }

        public override void CopyTo(int startIndex, char[] destination, int destinationIndex, int count)
        {
            var span = GetCompositeSpan(startIndex, count);

            _text.CopyTo(span.Start, destination, destinationIndex, span.Length);
        }

        TextSpan GetCompositeSpan(int start, int length)
        {
            int compositeStart = Math.Min(_text.Length, _span.Start + start);
            int compositeEnd = Math.Min(_text.Length, compositeStart + length);

            return TextSpan.FromBounds(compositeStart, compositeEnd);
        }
    }
}