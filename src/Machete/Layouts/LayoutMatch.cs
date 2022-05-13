namespace Machete.Layouts
{
    /// <summary>
    /// Returned by a layout property query, which is subsequently used to set the result to the property.
    /// </summary>
    /// <typeparam name="TLayout">The layout type</typeparam>
    public interface LayoutMatch<in TLayout>
        where TLayout : Layout
    {
        void Apply(TLayout layout);
    }
}