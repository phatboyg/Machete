namespace Machete.Slices.Providers
{
    public class EmptyEntityPropertyFormatter<TEntity> :
        IEntityPropertyFormatter<TEntity>
        where TEntity : Entity
    {
        public void Format(FormatContext context, TEntity entity)
        {
        }
    }
}