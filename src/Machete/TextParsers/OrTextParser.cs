namespace Machete.TextParsers
{
    using System;


    /// <summary>
    /// Selects a matching result from the first parser, and if it does not return a result then use the second parser
    /// </summary>
    public class OrTextParser :
        ITextParser
    {
        readonly ITextParser _first;
        readonly ITextParser _second;

        public OrTextParser(ITextParser first, ITextParser second)
        {
            _first = first ?? throw new ArgumentNullException(nameof(first));
            _second = second ?? throw new ArgumentNullException(nameof(second));
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var result = _first.Parse(text, span);
            
            return result.HasResult ? result : _second.Parse(text, span);
        }
    }


    /// <summary>
    /// Selects a matching result from the first parser, and if it does not return a result then use the second parser
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class OrTextParser<T> :
        ITextParser<T>
    {
        readonly ITextParser<T> _first;
        readonly ITextParser<T> _second;

        public OrTextParser(ITextParser<T> first, ITextParser<T> second)
        {
            _first = first ?? throw new ArgumentNullException(nameof(first));
            _second = second ?? throw new ArgumentNullException(nameof(second));
        }

        public Result<TextSpan, T> Parse(ParseText text, TextSpan span)
        {
            var result = _first.Parse(text, span);
            
            return result.HasResult ? result : _second.Parse(text, span);
        }
    }
}