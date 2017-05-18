namespace Machete.Layouts
{
    public interface ILayoutPropertyWriter<in TLayout, in TProperty>
        where TLayout : Layout
    {
        void SetProperty(TLayout layout, TProperty value);
    }
}