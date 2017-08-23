namespace Machete.Parsers.TextParsers
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

        public Result<TextCursor, char> Parse(TextCursor cursor)
        {
            if (cursor.Span.Length > 0 && _condition(cursor.Text[cursor.Span.Start]))
                return new Success<TextCursor, char>(cursor.Text[cursor.Span.Start], cursor.Skip(1));

            return new Unmatched<TextCursor, char>(cursor);
        }
    }
}