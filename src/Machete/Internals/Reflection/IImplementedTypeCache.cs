namespace Machete.Internals.Reflection
{
    public interface IImplementedTypeCache
    {
        /// <summary>
        /// Invokes the interface for each implemented type of the message
        /// </summary>
        /// <param name="implementedType"></param>
        /// <param name="includeActualType"></param>
        void EnumerateImplementedTypes(IImplementedType implementedType, bool includeActualType);
    }
}