namespace Machete
{
    public interface IEntityPropertyFormatter<in TEntity>
        where TEntity : Entity
    {
        void Format(FormatEntityContext<TEntity> context);
    }
}