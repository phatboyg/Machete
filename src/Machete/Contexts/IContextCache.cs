namespace Machete.Contexts
{
    /// <summary>
    /// The context properties.
    /// </summary>
    public interface IContextCache :
        IReadOnlyContextCollection
    {
        /// <summary>
        /// Return an existing or create a new property.
        /// </summary>
        /// <param name="contextFactory"></param>
        /// <returns></returns>
        T GetOrAddContext<T>(ContextFactory<T> contextFactory)
            where T : class;

        /// <summary>
        /// Add or update a new property.
        /// </summary>
        /// <param name="addFactory"></param>
        /// <param name="contextFactory"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> contextFactory)
            where T : class;
    }
}