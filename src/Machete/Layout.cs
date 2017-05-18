namespace Machete
{
    public interface Layout<out TLayout> :
        ILayout
        where TLayout : Layout
    {
        TLayout Value { get; }
    }


    public interface Layout
    {
    }
}