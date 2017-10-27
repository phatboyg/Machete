namespace Machete.Formatters
{
    public class EmptyEntityPropertyFormatter<TEntity> :
        IEntityPropertyFormatter<TEntity>
        where TEntity : Entity
    {
        public void Format(FormatEntityContext<TEntity> context)
        {
        }
    }
}