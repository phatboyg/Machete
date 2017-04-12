namespace Machete
{
    public interface Group<out TEntity> :
        Entity<TEntity>
        where TEntity : Entity
    {
    }
}