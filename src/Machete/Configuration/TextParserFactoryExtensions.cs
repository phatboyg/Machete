namespace Machete
{
    using System;
    using ParserConfiguration;
    using ParserConfiguration.Builders;


    public static class TextParserFactoryExtensions
    {
        public static ITextParser<T> CreateText<T>(this IParserFactorySelector selector, Func<ITextParserBuilder, ITextParser<T>> parserBuilderCallback)
        {
            var builder = new TextParserBuilder();

            return parserBuilderCallback(builder);
        }

        public static ITextParser CreateText(this IParserFactorySelector selector, Func<ITextParserBuilder, ITextParser> parserBuilderCallback)
        {
            var builder = new TextParserBuilder();

            return parserBuilderCallback(builder);
        }
    }
}