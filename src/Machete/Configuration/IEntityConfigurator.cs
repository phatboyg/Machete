namespace Machete
{
    public interface IEntityConfigurator<out TEntity>
        where TEntity : Entity
    {
        bool Required { set; }
    }
}