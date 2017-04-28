namespace Machete.Parsers
{
    using System;


    public class CharParser :
        TextParser<char>
    {
        readonly Func<char, bool> _condition;

        public CharParser(Func<char, bool> condition)
        {
            _condition = condition;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.Start < span.End && _condition(text[span.Start]))
                return new Success<TextSpan, TextSpan>(new TextSpan(span.Start, 1), TextSpan.FromBounds(span.Start + 1, span.End));

            return new Unmatched<TextSpan, TextSpan>(span);
        }

        public Result<TextCursor, char> Parse(TextCursor cursor)
        {
            if (cursor.Span.Length > 0 && _condition(cursor.Text[cursor.Span.Start]))
                return new Success<TextCursor, char>(cursor.Text[cursor.Span.Start], cursor.Skip(1));

            return new Unmatched<TextCursor, char>(cursor);
        }
    }
}