namespace Machete
{
    using Contexts;


    public interface IContext :
        IReadOnlyContext
    {
        /// <summary>
        /// Returns an existing payload or creates the payload using the factory method provided
        /// </summary>
        /// <typeparam name="T">The payload type</typeparam>
        /// <param name="contextFactory">The payload factory is the payload is not present</param>
        /// <returns>The payload</returns>
        T GetOrAddContext<T>(ContextFactory<T> contextFactory)
            where T : class;

        /// <summary>
        /// Add a new or update an existing payload
        /// </summary>
        /// <param name="addFactory"></param>
        /// <param name="updateFactory"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> updateFactory)
            where T : class;

        IReadOnlyContextCollection CurrentContext { get; }
    }
}