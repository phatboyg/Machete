namespace Machete.TextParsers
{
    public class OrTextParser :
        ITextParser
    {
        readonly ITextParser _first;
        readonly ITextParser _second;

        public OrTextParser(ITextParser first, ITextParser second)
        {
            _first = first;
            _second = second;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var result = _first.Parse(text, span);
            if (result.HasResult)
                return result;

            return _second.Parse(text, span);
        }
    }


    public class OrTextParser<T> :
        ITextParser<T>
    {
        readonly ITextParser<T> _first;
        readonly ITextParser<T> _second;

        public OrTextParser(ITextParser<T> first, ITextParser<T> second)
        {
            _first = first;
            _second = second;
        }

        public Result<TextSpan, T> Parse(ParseText text, TextSpan span)
        {
            var result = _first.Parse(text, span);
            if (result.HasResult)
                return result;

            return _second.Parse(text, span);
        }
    }
}