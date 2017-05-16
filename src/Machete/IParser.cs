namespace Machete
{
    using System.Threading.Tasks;
    using Texts;


    public interface IParser<TSchema>
        where TSchema : Entity
    {
        ISchema<TSchema> Schema { get; }

        /// <summary>
        /// Parse the text into a parsed schema
        /// </summary>
        /// <param name="text"></param>
        /// <param name="span"></param>
        /// <returns></returns>
        ParsedResult<TSchema> Parse(ParseText text, TextSpan span);

        /// <summary>
        /// Parse the text asynchronously into a parsed schema
        /// </summary>
        /// <param name="text"></param>
        /// <param name="span"></param>
        /// <returns></returns>
        Task<ParsedResult<TSchema>> ParseAsync(StreamText text, TextSpan span);
    }
}