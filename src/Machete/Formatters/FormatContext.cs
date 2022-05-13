namespace Machete.Formatters
{
    using System;


    /// <summary>
    /// Encapsulates the context used to format entities/values.
    /// </summary>
    public interface FormatContext :
        IContext
    {
        /// <summary>
        /// The current culture, used for formatting value types.
        /// </summary>
        IFormatProvider CurrentCulture { get; }

        /// <summary>
        /// The position
        /// </summary>
        int Position { get; }

        /// <summary>
        /// Append the text slice to the output.
        /// </summary>
        /// <param name="slice"></param>
        void Append(TextSlice slice);

        /// <summary>
        /// Append the text to the output.
        /// </summary>
        /// <param name="text"></param>
        void Append(string text);

        /// <summary>
        /// Append the character to the output.
        /// </summary>
        /// <param name="c"></param>
        void Append(char c);

        /// <summary>
        /// Clear any of the content added within this context (which may just reset the position held by the context).
        /// </summary>
        void Clear();

        /// <summary>
        /// Create a value context for the specified property.
        /// </summary>
        /// <param name="value">The value</param>
        /// <typeparam name="T">The value type</typeparam>
        /// <returns></returns>
        FormatValueContext<T> CreateValueContext<T>(Value<T> value);

        /// <summary>
        /// Create an entity context for the specified property.
        /// </summary>
        /// <param name="entity">The entity</param>
        /// <typeparam name="T">The entity type</typeparam>
        /// <returns></returns>
        FormatEntityContext<T> CreateEntityContext<T>(T entity)
            where T : Entity;

        /// <summary>
        /// Trim the output at the specified position.
        /// </summary>
        /// <param name="position"></param>
        void Trim(int position);
    }
}