namespace Machete.Translators.PropertyTranslaters.PropertyProviders
{
    using System.Threading.Tasks;


    public class StaticTranslatePropertyProvider<TProperty, TInput, TSchema> :
        ITranslatePropertyProvider<TProperty, TInput, TSchema>
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly TProperty _propertyValue;

        public StaticTranslatePropertyProvider(TProperty propertyValue)
        {
            _propertyValue = propertyValue;
        }

        public Task<TProperty> GetProperty(TranslateContext<TInput, TSchema> context)
        {
            return Task.FromResult(_propertyValue);
        }
    }
}