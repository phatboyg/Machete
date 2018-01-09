namespace Machete.Parsers
{
    using System;


    /// <summary>
    /// Selects a matching result from the parser, and applies a projection to the result type
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TSelect"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class SelectValueParser<TInput, T, TSelect, TResult> :
        IParser<TInput, TResult>
    {
        readonly IParser<TInput, T> _parser;
        readonly Func<T, TSelect, TResult> _projector;
        readonly Func<T, Value<TSelect>> _selector;

        public SelectValueParser(IParser<TInput, T> parser, Func<T, Value<TSelect>> selector, Func<T, TSelect, TResult> projector)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _selector = selector ?? throw new ArgumentNullException(nameof(selector));
            _projector = projector ?? throw new ArgumentNullException(nameof(projector));
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


    /// <summary>
    /// Selects a matching result from the parser, and applies a projection to the result type
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class SelectValueParser<TInput, T, TResult> :
        IParser<TInput, Value<TResult>>
    {
        readonly IParser<TInput, Value<T>> _parser;
        readonly Func<T, Value<TResult>> _projector;

        public SelectValueParser(IParser<TInput, Value<T>> parser, Func<T, Value<TResult>> projector)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _projector = projector ?? throw new ArgumentNullException(nameof(projector));
        }

        public Result<Cursor<TInput>, Value<TResult>> Parse(Cursor<TInput> input)
        {
            var parsed = _parser.Parse(input);
            if (!parsed.HasResult || !parsed.Result.HasValue)
                return new Unmatched<Cursor<TInput>, Value<TResult>>(parsed.Next);

            return new Success<Cursor<TInput>, Value<TResult>>(_projector(parsed.Result.Value), parsed.Next);
        }
    }
}