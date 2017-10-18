namespace Machete.Formatters
{
    public static class Formatter
    {
        /// <summary>
        /// The factory base for all parsers, to make it easy to discover available parser types.
        /// </summary>
        public static readonly IFormatterFactorySelector Factory = new UnusedFormatterFactorySelector();


        class UnusedFormatterFactorySelector :
            IFormatterFactorySelector
        {
        }
    }
}