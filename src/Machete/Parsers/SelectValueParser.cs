namespace Machete.Parsers
{
    using System;


    public class SelectValueParser<TInput, T, TSelect, TResult> :
        IParser<TInput, TResult>
    {
        readonly IParser<TInput, T> _parser;
        readonly Func<T, TSelect, TResult> _projector;
        readonly Func<T, Value<TSelect>> _selector;

        public SelectValueParser(IParser<TInput, T> parser, Func<T, Value<TSelect>> selector, Func<T, TSelect, TResult> projector)
        {
            _parser = parser;

            _selector = selector;
            _projector = projector;
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            var parsed = _parser.Parse(input);
            if (!parsed.HasResult)
                return new Unmatched<Cursor<TInput>, TResult>(parsed.Next);

            var value = parsed.Result;
            var selected = _selector(value);
            if (!selected.IsPresent || !selected.HasValue)
                return new Unmatched<Cursor<TInput>, TResult>(parsed.Next);

            return new Success<Cursor<TInput>, TResult>(_projector(value, selected.Value), parsed.Next);
        }
    }
}