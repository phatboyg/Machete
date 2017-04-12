namespace Machete
{
    public interface IDateTimeValueConfigurator<out TValue> :
        IValueConfigurator<TValue>
    {
        string Format { set; }
    }


    public interface IEntityConfigurator<out TEntity>
        where TEntity : Entity
    {
        bool Required { set; }
    }


    public interface IGroupConfigurator<out TTemplate>
    {
        bool Required { set; }
    }
}