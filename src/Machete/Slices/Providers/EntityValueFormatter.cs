namespace Machete.Slices.Providers
{
    public class EntityValueFormatter<TEntity, TSchema> :
        IValueFormatter<TEntity>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly IEntityFormatter<TEntity> _entityConverter;

        public EntityValueFormatter(IEntityFormatter<TEntity> entityConverter)
        {
            _entityConverter = entityConverter;
        }

        public bool TryGetString(Value<TEntity> value, out string text)
        {
            if (value.HasValue)
            {
                text = _entityConverter.FormatEntity(value.Value).Text.ToString();
                return true;
            }

            text = string.Empty;
            return false;
        }
    }
}