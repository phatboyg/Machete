namespace Machete
{
    using System.Threading.Tasks;
    using Texts;


    public interface IParser<TSchema>
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
        Task<ParseResult<TSchema>> ParseAsync(StreamText text, TextSpan span);
    }
}