namespace Machete
{
    public interface IEntitySelector
    {
        /// <summary>
        /// Selects the appropriate schema type for the text fragment
        /// </summary>
        /// <param name="slice">The text fragment being parsed</param>
        /// <param name="entityInfo">The matching schema type</param>
        /// <returns>True if a matching schema type was found, otherwise false</returns>
        bool SelectEntity(TextSlice slice, out EntityInfo entityInfo);

        /// <summary>
        /// Matches the schema type to the specified schema element
        /// </summary>
        /// <param name="entity">The schema element</param>
        /// <param name="entityInfo">The matching schema type</param>
        /// <typeparam name="T">The schema element type</typeparam>
        /// <returns>True if a matching schema type was found, otherwise false</returns>
        bool SelectEntity<T>(T entity, out EntityInfo entityInfo);
    }
}