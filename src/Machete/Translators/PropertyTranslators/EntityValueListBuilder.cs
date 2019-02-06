namespace Machete.Translators.PropertyTranslators
{
    using Values;


    public class EntityValueListBuilder<T, TSchema>
        where TSchema : Entity
        where T : TSchema
    {
        readonly ListValueList<T> _results;

        public EntityValueListBuilder()
        {
            _results = new ListValueList<T>();
        }

        public void Add(EntityResult<TSchema> result)
        {
            if (!result.HasResult)
                return;
            
            for (int i = 0; result.TryGetEntity(i, out T entity); i++)
            {
                _results.Add(entity);
            }
        }

        public ValueList<T> ValueList => _results;
    }
}