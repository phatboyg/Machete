namespace Machete.Translators.PropertyTranslators
{
    using System.Collections.Generic;
    using System.Threading.Tasks;


    public class PropertyTranslatorList<TResult, TInput, TSchema> :
        IPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TResult : TSchema
        where TInput : TSchema
    {
        readonly IReadOnlyList<IPropertyTranslator<TResult, TInput, TSchema>> _translaters;

        public PropertyTranslatorList(IReadOnlyList<IPropertyTranslator<TResult, TInput, TSchema>> translaters)
        {
            _translaters = translaters;
        }

        public async Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
        {
            foreach (var translater in _translaters)
            {
                await translater.Apply(entity, context).ConfigureAwait(false);
            }
        }
    }
}