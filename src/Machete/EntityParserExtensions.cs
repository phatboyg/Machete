namespace Machete
{
    using System;
    using Texts;


    public static class EntityParserExtensions
    {
        public static ParseResult<TSchema> Parse<TSchema>(this IEntityParser<TSchema> parser, string text)
            where TSchema : Entity
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            var stringText = new StringText(text);

            return parser.Parse(stringText, new TextSpan(0, stringText.Length));
        }
    }
}