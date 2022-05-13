﻿namespace Machete.Parsers
{
    using System;


    /// <summary>
    /// Peek parses the input but does not move the Cursor forward.
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class PeekParser<TInput, TResult> :
        IParser<TInput, TResult>
    {
        readonly IParser<TInput, TResult> _parser;

        public PeekParser(IParser<TInput, TResult> parser)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, TResult> result = _parser.Parse(input);
            if (result.HasResult)
                return new Success<Cursor<TInput>, TResult>(result.Result, input);

            return new Unmatched<Cursor<TInput>, TResult>(input);
        }
    }
}