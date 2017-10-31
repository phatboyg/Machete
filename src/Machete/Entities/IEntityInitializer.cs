namespace Machete.Entities
{
    public interface IEntityInitializer<in TEntity>
        where TEntity : Entity
    {
        void Initialize(TEntity entity);
    }
}