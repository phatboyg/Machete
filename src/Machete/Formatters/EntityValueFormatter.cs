namespace Machete.Formatters
{
    /// <summary>
    /// Formats an entity value, using the entity formatter
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public class EntityValueFormatter<TEntity, TSchema> :
        IValueFormatter<TEntity>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly IEntityFormatter<TEntity> _entityFormatter;

        public EntityValueFormatter(IEntityFormatter<TEntity> entityFormatter)
        {
            _entityFormatter = entityFormatter;
        }

        public void Format(FormatValueContext<TEntity> context)
        {
            if (context.Value.HasValue)
                _entityFormatter.Format(context, context.Value.Value);
        }
    }
}