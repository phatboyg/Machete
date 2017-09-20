namespace Machete.Contexts
{
    /// <summary>
    /// Supports the reading and writing of the property cache
    /// </summary>
    public interface IContextCollection :
        IReadOnlyContextCollection
    {
        IContextCollection Add(IContextValue context);
    }
}