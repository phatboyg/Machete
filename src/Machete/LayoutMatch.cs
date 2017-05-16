namespace Machete
{
    /// <summary>
    /// Returned by a layout property query, which is subsequently used to set the result to the property
    /// </summary>
    /// <typeparam name="TLayout">The layout type</typeparam>
    /// <typeparam name="TSchema">The schema type</typeparam>
    public interface LayoutMatch<in TLayout, in TSchema>
        where TLayout : Layout
        where TSchema : Entity
    {
        void Apply(TLayout layout);
    }
}