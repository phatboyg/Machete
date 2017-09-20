namespace Machete.Texts
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using System.Text.RegularExpressions;


    /// <summary>
    /// A <see cref="ParseText"/> backed by a <see cref="StringBuilder"/>, allowing it to be updated
    /// behind the scenes.
    /// </summary>
    public class StringBuilderText :
        ParseText
    {
        readonly StringBuilder _builder;

        public StringBuilderText(StringBuilder builder)
        {
            Debug.Assert(builder != null);

            _builder = builder;
        }

        public override char this[int position] => _builder[position];

        public override int Length => _builder.Length;

        public StringBuilder StringBuilder => _builder;

        public override void AppendTo(StringBuilder builder, TextSpan span)
        {
            CheckSpanInLength(span);

            builder.Append(builder.ToString(span.Start, span.Length));
        }

        public override int Compare(string comparator, int index, TextSpan span, StringComparison comparison)
        {
            return string.Compare(comparator, index, _builder.ToString(span.Start, span.Length), 0, span.Length, comparison);
        }

        public override Match Match(Regex regex, TextSpan span)
        {
            return regex.Match(_builder.ToString(span.Start, span.Length));
        }

        public override string ToString(TextSpan span)
        {
            return _builder.ToString(span.Start, span.Length);
        }

        public override void CopyTo(int startIndex, char[] destination, int destinationIndex, int count)
        {
            _builder.CopyTo(startIndex, destination, destinationIndex, count);
        }
    }
}