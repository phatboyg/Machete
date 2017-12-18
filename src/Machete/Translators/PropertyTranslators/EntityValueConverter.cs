namespace Machete.Translators.PropertyTranslators
{
    using Values;


    public class EntityValueConverter<T, TSchema>
        where TSchema : Entity
        where T : TSchema
    {
        public Value<T> Convert(EntityResult<TSchema> result)
        {
            if (result.HasResult && result.TryGetEntity(0, out T entity))
            {
                return new ConstantValue<T>(entity);
            }

            return Value.Missing<T>();
        }
    }
}