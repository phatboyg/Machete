namespace Machete
{
    using System;


    /// <summary>
    /// Encapsulates the context used to format entities/values
    /// </summary>
    public interface FormatContext
    {
        /// <summary>
        /// Append the text slice to the output
        /// </summary>
        /// <param name="slice"></param>
        void Append(TextSlice slice);

        /// <summary>
        /// Append the text to the output
        /// </summary>
        /// <param name="text"></param>
        void Append(string text);

        void Append(char c);

        IFormatProvider CurrentCulture { get; }

        /// <summary>
        /// The position
        /// </summary>
        int Position { get; }

        /// <summary>
        /// Clear any of the content added within this context (which may just reset the position held by the context)
        /// </summary>
        void Clear();

        FormatValueContext<T> CreateValueContext<T>(Value<T> value);

        FormatEntityContext<T> CreateEntityContext<T>(T entity)
            where T : Entity;

        /// <summary>
        /// Trim the output at the specified position
        /// </summary>
        /// <param name="position"></param>
        void Trim(int position);
    }
}