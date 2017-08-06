namespace Machete.SchemaConfiguration
{
    public interface ILayoutConfigurator<out TLayout>
    {
        bool Required { set; }
    }
}