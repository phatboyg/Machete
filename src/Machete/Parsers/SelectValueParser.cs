namespace Machete.Parsers
{
    using System;


    public class SelectValueParser<TInput, T, TSelect, TResult> :
        Parser<TInput, TResult>
    {
        readonly Parser<TInput, T> _parser;
        readonly Func<T, TSelect, TResult> _projector;
        readonly Func<T, Value<TSelect>> _selector;

        public SelectValueParser(Parser<TInput, T> parser, Func<T, Value<TSelect>> selector, Func<T, TSelect, TResult> projector)
        {
            _parser = parser;

            _selector = selector;
            _projector = projector;
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, T> parsed = _parser.Parse(input);
            if (parsed.HasValue)
            {
                T value = parsed.Value;
                Value<TSelect> selected = _selector(value);
                if (selected.IsPresent && selected.HasValue)
                {
                    var result = _projector(value, selected.Value);
                    return new Success<Cursor<TInput>, TResult>(result, parsed.Next);
                }
            }

            return new Unmatched<Cursor<TInput>, TResult>(parsed.Next);
        }
    }
}