namespace Machete.Contexts
{
    using System;


    /// <summary>
    /// Supports the reading of the property cache.
    /// </summary>
    public interface IReadOnlyContextCollection
    {
        /// <summary>
        /// Returns the current context collection.
        /// </summary>
        IReadOnlyContextCollection CurrentContext { get; }

        /// <summary>
        /// Checks if the property exists in the cache.
        /// </summary>
        /// <param name="contextType">The property type</param>
        /// <returns>True if the property exists in the cache, otherwise false</returns>
        bool HasContext(Type contextType);
        
        /// <summary>
        /// Returns the value of the property if it exists in the cache.
        /// </summary>
        /// <typeparam name="T">The property type</typeparam>
        /// <param name="context">The property value</param>
        /// <returns>True if the value was returned, otherwise false</returns>
        bool TryGetContext<T>(out T context)
            where T : class;
    }
}