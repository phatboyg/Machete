namespace Machete.TranslateConfiguration
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Translators;


    public class EntityPropertyTranslatorList<TResult, TInput, TSchema> :
        IEntityPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TResult : TSchema
        where TInput : TSchema
    {
        readonly IReadOnlyList<IEntityPropertyTranslator<TResult, TInput, TSchema>> _translaters;

        public EntityPropertyTranslatorList(IReadOnlyList<IEntityPropertyTranslator<TResult, TInput, TSchema>> translaters)
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