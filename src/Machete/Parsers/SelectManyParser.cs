namespace Machete.Parsers
{
    using System;


    /// <summary>
    /// Applies a projection to a list of list and returns a flattened list
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TSelect"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class SelectManyParser<TInput, T, TSelect, TResult> :
        IParser<TInput, TResult>
    {
        readonly IParser<TInput, T> _parser;
        readonly Func<T, TSelect, TResult> _projector;
        readonly Func<T, IParser<TInput, TSelect>> _selector;

        public SelectManyParser(IParser<TInput, T> parser, Func<T, IParser<TInput, TSelect>> selector, Func<T, TSelect, TResult> projector)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _selector = selector ?? throw new ArgumentNullException(nameof(selector));
            _projector = projector ?? throw new ArgumentNullException(nameof(projector));
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, T> parsed = _parser.Parse(input);
            if (!parsed.HasResult)
                return new Unmatched<Cursor<TInput>, TResult>(parsed.Next);
            
            T value = parsed.Result;
            Result<Cursor<TInput>, TSelect> selected = _selector(value).Parse(parsed.Next);
            if (!selected.HasResult)
                return new Unmatched<Cursor<TInput>, TResult>(parsed.Next);

            return new Success<Cursor<TInput>, TResult>(_projector(value, selected.Result), selected.Next);
        }
    }
}