namespace Machete
{
    public interface IEntityPropertyFormatter<in TEntity>
        where TEntity : Entity
    {
        void Format(FormatContext context, TEntity entity);
    }
}