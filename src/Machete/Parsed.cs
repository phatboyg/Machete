namespace Machete
{
    /// <summary>
    /// Text parsed into the specified schema
    /// </summary>
    /// <typeparam name="TSchema"></typeparam>
    public interface Parsed<in TSchema>
        where TSchema : Entity
    {
        bool TryGetEntity<T>(int index, out T entity)
            where T : TSchema;
    }
}