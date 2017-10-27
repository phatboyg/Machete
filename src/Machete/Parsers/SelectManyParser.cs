namespace Machete.Parsers
{
    using System;


    public class SelectManyParser<TInput, T, TSelect, TResult> :
        IParser<TInput, TResult>
    {
        readonly IParser<TInput, T> _parser;
        readonly Func<T, TSelect, TResult> _projector;
        readonly Func<T, IParser<TInput, TSelect>> _selector;

        public SelectManyParser(IParser<TInput, T> parser, Func<T, IParser<TInput, TSelect>> selector, Func<T, TSelect, TResult> projector)
        {
            _parser = parser;

            _selector = selector;
            _projector = projector;
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, T> parsed = _parser.Parse(input);
            if (parsed.HasResult)
            {
                T value = parsed.Result;
                Result<Cursor<TInput>, TSelect> selected = _selector(value).Parse(parsed.Next);
                if (selected.HasResult)
                {
                    TResult result = _projector(value, selected.Result);
                    return new Success<Cursor<TInput>, TResult>(result, selected.Next);
                }
            }

            return new Unmatched<Cursor<TInput>, TResult>(parsed.Next);
        }
    }
}