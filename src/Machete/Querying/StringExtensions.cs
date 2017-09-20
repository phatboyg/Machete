namespace Machete
{
    using System;
    using TextParsers;


    public static class StringExtensions
    {
        /// <summary>
        /// Match the specified string
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static TextParser String(this TextParser parser, string text)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new StringTextParser(parser, text);
        }
    }
}