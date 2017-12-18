namespace Machete.Translators.PropertyTranslators
{
    using System.Collections.Generic;
    using System.Threading.Tasks;


    public class PropertyTranslatorList<TResult, TSchema> :
        IPropertyTranslator<TResult, TSchema>
        where TSchema : Entity
        where TResult : TSchema
    {
        readonly IReadOnlyList<IPropertyTranslator<TResult, TSchema>> _translaters;

        public PropertyTranslatorList(IReadOnlyList<IPropertyTranslator<TResult, TSchema>> translaters)
        {
            _translaters = translaters;
        }

        public async Task Apply(TResult entity, TranslateContext<TSchema> context)
        {
            foreach (var translater in _translaters)
            {
                await translater.Apply(entity, context).ConfigureAwait(false);
            }
        }
    }
}