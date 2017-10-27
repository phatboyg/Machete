namespace Machete
{
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