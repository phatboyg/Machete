namespace Machete.Parsers
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
}