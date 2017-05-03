namespace Machete
{
    public interface IGroupConfigurator<out TTemplate>
    {
        bool Required { set; }
    }
}