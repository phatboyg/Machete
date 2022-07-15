namespace Machete.Texts
{
    using System;
    using System.Buffers;
    using System.Diagnostics;
    using System.Text;
    using System.Text.RegularExpressions;


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
                builder.Append(_text);
            else
                builder.Append(_text, span.Start, span.Length);
        }

        public override int Compare(string comparator, int index, TextSpan span, StringComparison comparison)
        {
            return string.Compare(comparator, index, _text, span.Start, span.Length, comparison);
        }

        public override Match Match(Regex regex, TextSpan span)
        {
            return regex.Match(_text, span.Start, span.Length);
        }

        public override int IndexOf(char value, TextSpan span)
        {
            return _text.IndexOf(value, span.Start, span.Length);
        }
    }


    // public class MemoryText :
    //     ParseText
    // {
    //     readonly ReadOnlyMemory<char> _memory;
    //
    //     public MemoryText(ReadOnlyMemory<char> memory)
    //     {
    //         _memory = memory;
    //     }
    //
    //     public override int Length => _memory.Length;
    //
    //     public override char this[int position] => _memory.Span[position];
    //
    //     public override string ToString(TextSpan span)
    //     {
    //         if (span.Start == 0)
    //         {
    //             if (span.Length == _memory.Length)
    //                 return new string(_memory.Span);
    //             if (span.Length == 0)
    //                 return string.Empty;
    //         }
    //
    //         return new string(_memory.Slice(span.Start, span.Length).Span);
    //     }
    //
    //     public override void CopyTo(int startIndex, char[] destination, int destinationIndex, int count)
    //     {
    //         _text.CopyTo(startIndex, destination, destinationIndex, count);
    //     }
    //
    //     public override void AppendTo(StringBuilder builder, TextSpan span)
    //     {
    //         if (span.Start == 0 && span.Length == _text.Length)
    //             builder.Append(_text);
    //         else
    //             builder.Append(_text, span.Start, span.Length);
    //     }
    //
    //     public override int Compare(string comparator, int index, TextSpan span, StringComparison comparison)
    //     {
    //         return string.Compare(comparator, index, _text, span.Start, span.Length, comparison);
    //     }
    //
    //     public override Match Match(Regex regex, TextSpan span)
    //     {
    //         return regex.Match(_text, span.Start, span.Length);
    //     }
    //
    //     public override int IndexOf(char value, TextSpan span)
    //     {
    //         return _text.IndexOf(value, span.Start, span.Length);
    //     }
    // }
}