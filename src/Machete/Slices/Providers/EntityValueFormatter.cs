namespace Machete.Slices.Providers
{
    public class EntityValueFormatter<TEntity> :
        IValueFormatter<TEntity>
        where TEntity : Entity
    {
        readonly IEntityMap<TEntity> _entityMap;

        public EntityValueFormatter(IEntityMap<TEntity> entityMap)
        {
            _entityMap = entityMap;
        }

        public bool TryGetString(Value<TEntity> value, out string text)
        {
            if (value.HasValue)
            {
                text = _entityMap.GetSlice(value.Value).Text.ToString();
                return true;
            }

            text = string.Empty;
            return false;
        }
    }
}