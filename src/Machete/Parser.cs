namespace Machete
{
    public interface Parser<TInput> :
        Parser<TInput, TInput>
    {
    }


    /// <summary>
    /// A parser determines if an input matches the requirements and if so returns the result
    /// </summary>
    /// <typeparam name="TInput">The parser input type</typeparam>
    /// <typeparam name="TResult">The parser result type</typeparam>
    public interface Parser<TInput, out TResult>
    {
        Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input);
    }


    /// <summary>
    /// The base entry class for creating/using a <see cref="Parser"/>.
    /// </summary>
    public static class Parser
    {
        /// <summary>
        /// The factory base for all parsers, to make it easy to discover available parser types.
        /// </summary>
        public static readonly IParserFactorySelector Factory = new UnusedParserFactorySelector();


        class UnusedParserFactorySelector :
            IParserFactorySelector
        {
        }
    }
}