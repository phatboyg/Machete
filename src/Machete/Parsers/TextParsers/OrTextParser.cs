namespace Machete.Parsers.TextParsers
{
    public class OrTextParser :
        TextParser
    {
        readonly TextParser _first;
        readonly TextParser _second;

        public OrTextParser(TextParser first, TextParser second)
        {
            _first = first;
            _second = second;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var result = _first.Parse(text, span);
            if (result.HasValue)
                return result;

            return _second.Parse(text, span);
        }
    }


    public class OrTextParser<T> :
        TextParser<T>
    {
        readonly TextParser<T> _first;
        readonly TextParser<T> _second;

        public OrTextParser(TextParser<T> first, TextParser<T> second)
        {
            _first = first;
            _second = second;
        }

        public Result<TextSpan, T> Parse(ParseText text, TextSpan span)
        {
            var result = _first.Parse(text, span);
            if (result.HasValue)
                return result;

            return _second.Parse(text, span);
        }
    }
}