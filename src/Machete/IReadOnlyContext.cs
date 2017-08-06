namespace Machete
{
    using System;


    public interface IReadOnlyContext
    {
        /// <summary>
        /// Checks if a payload is present in the context
        /// </summary>
        /// <param name="contextType"></param>
        /// <returns></returns>
        bool HasContext(Type contextType);

        /// <summary>
        /// Retrieves a payload from the pipe context
        /// </summary>
        /// <typeparam name="T">The payload type</typeparam>
        /// <param name="context">The payload</param>
        /// <returns></returns>
        bool TryGetContext<T>(out T context)
            where T : class;
    }
}