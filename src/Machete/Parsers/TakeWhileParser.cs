namespace Machete.Parsers
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Parses a series of results into a list, returning only the specified elements where the condition evaluates to true
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class TakeWhileParser<TInput, T> :
        IParser<TInput, IReadOnlyList<T>>
    {
        readonly IParser<TInput, T> _parser;
        readonly Func<T, bool> _condition;

        public TakeWhileParser(IParser<TInput, T> parser, Func<T, bool> condition)
        {
            _parser = parser;
            _condition = condition;
        }

        public Result<Cursor<TInput>, IReadOnlyList<T>> Parse(Cursor<TInput> input)
        {
            Cursor<TInput> next = input;

            Result<Cursor<TInput>, T> result = _parser.Parse(next);
            if (!result.HasResult)
                return new Unmatched<Cursor<TInput>, IReadOnlyList<T>>(input);
                
            var series = new List<T>();
                
            if (_condition(result.Result))
                series.Add(result.Result);
                
            while (result.HasResult)
            {
                // not moving the cursor forward means the parser is stalled, so break
                if (next == result.Next)
                    break;

                next = result.Next;

                result = _parser.Parse(next);

                if (!result.HasResult || !_condition(result.Result))
                    continue;
                    
                series.Add(result.Result);
            }
                
            if (series.Count <= 0)
                return new Unmatched<Cursor<TInput>, IReadOnlyList<T>>(next);

            return new Success<Cursor<TInput>, IReadOnlyList<T>>(series, next);
        }
    }
}