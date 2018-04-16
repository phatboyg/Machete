namespace Machete
{
    using System.IO;
    using System.Threading.Tasks;


    /// <summary>
    /// Formats a collection of entities, using the individual entity formatters
    /// </summary>
    /// <typeparam name="TSchema">The schema type</typeparam>
    public interface IFormatter<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Format an entity collection to the specified stream.
        /// </summary>
        /// <param name="stream">The output stream</param>
        /// <param name="input">The input entity collection</param>
        /// <returns></returns>
        Task<FormatResult<TSchema>> FormatAsync(Stream stream, EntityCollection<TSchema> input);
    }
}