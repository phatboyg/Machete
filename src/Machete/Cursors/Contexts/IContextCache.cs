namespace Machete.Cursors.Contexts
{
    /// <summary>
    /// The context properties
    /// </summary>
    public interface IContextCache :
        IReadOnlyContextCollection
    {
        /// <summary>
        /// Return an existing or create a new property
        /// </summary>
        /// <param name="contextFactory"></param>
        /// <returns></returns>
        T GetOrAddContext<T>(ContextFactory<T> contextFactory)
            where T : class;

        T AddOrUpdateContext<T>(ContextFactory<T> addFactory, UpdateContextFactory<T> contextFactory)
            where T : class;
    }
}