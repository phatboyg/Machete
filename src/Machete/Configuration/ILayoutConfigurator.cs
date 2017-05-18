namespace Machete
{
    public interface ILayoutConfigurator<out TLayout>
    {
        bool Required { set; }
    }
}