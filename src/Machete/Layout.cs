namespace Machete
{
    public interface Layout<out TLayout> :
        ILayout
        where TLayout : Layout
    {
        TLayout Value { get; }
    }


    /// <summary>
    /// A layout defines a series of entities which compose a structure
    /// </summary>
    public interface Layout
    {
    }
}