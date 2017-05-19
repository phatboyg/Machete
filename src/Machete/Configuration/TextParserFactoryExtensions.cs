namespace Machete
{
    using System;
    using ParserConfiguration;
    using ParserConfiguration.Builders;


    public static class TextParserFactoryExtensions
    {
        public static TextParser<T> CreateText<T>(this IParserFactorySelector selector, Func<ITextParserBuilder, TextParser<T>> parserBuilderCallback)
        {
            var builder = new TextParserBuilder();

            return parserBuilderCallback(builder);
        }
    }
}