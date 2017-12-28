namespace Machete
{
    using System.Threading.Tasks;
    using Texts;


    /// <summary>
    /// Use this parser to convert text to an ordered collection of entities, the structure of which are defined by the parser's schema.
    /// </summary>
    /// <typeparam name="TSchema">The schema type</typeparam>
    public interface IEntityParser<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Parse the text into a parsed schema
        /// </summary>
        /// <param name="text"></param>
        /// <param name="span"></param>
        /// <returns></returns>
        ParseResult<TSchema> Parse(ParseText text, TextSpan span);

        /// <summary>
        /// Parse the stream asynchronously into a parsed schema
        /// </summary>
        /// <param name="text"></param>
        /// <param name="span"></param>
        /// <returns></returns>
        Task<ParseResult<TSchema>> ParseStream(StreamText text, TextSpan span);
    }
}