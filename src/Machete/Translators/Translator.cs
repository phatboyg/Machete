namespace Machete.Translators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;


    public class Translator<TSchema> :
        ITranslator<TSchema>
        where TSchema : Entity
    {
        readonly IReadOnlyDictionary<Type, IEntityTranslator<TSchema>> _entityTranslators;
        readonly TranslatorObservable<TSchema> _observers;
        ObserverHandle[] _handles;

        public Translator(IReadOnlyDictionary<Type, IEntityTranslator<TSchema>> entityTranslators)
        {
            _entityTranslators = entityTranslators;

            _observers = new TranslatorObservable<TSchema>();
            _handles = _entityTranslators.Values.Select(x => x.ConnectTranslateObserver(_observers)).ToArray();
        }

        public async Task<TranslateResult<TSchema>> Translate(TranslateContext<TSchema> context)
        {
            var results = context.CreateResultCollection();

            var index = 0;

            while (context.Source.TryGetEntity(index, out TSchema entity))
            {
                var entityResult = await TranslateEntity(context, entity).ConfigureAwait(false);

                results.Add(entityResult);

                index++;
            }

            return results.ToResult();
        }

        public ObserverHandle ConnectTranslateObserver(ITranslatorObserver<TSchema> observer)
        {
            return _observers.Connect(observer);
        }

        async Task<TranslateResult<TSchema>> TranslateEntity(TranslateContext<TSchema> context, TSchema entity)
        {
            // first, use the EntityType to quickly find a translator, if present
            if (_entityTranslators.TryGetValue(entity.EntityInfo.EntityType, out var translator))
            {
                var translateResult = await translator.Translate(context, entity).ConfigureAwait(false);
                if (translateResult.IsTranslated)
                    return translateResult;
            }
            
            // otherwise, try to discover one...
            var entityType = entity.GetType();
            
            var interfaceTypes = entityType.GetTypeInfo().GetInterfaces();
            if (interfaceTypes.Length == 0)
                return context.Result(entity, entityType);

            // TODO optimize this using similar approach to ImplementedMessageTypeCache in MT
            // TODO preload index with Entity implemented type
            
            foreach (var interfaceType in interfaceTypes)
            {
                if (_entityTranslators.TryGetValue(interfaceType, out var entityTranslator))
                {
                    var translateResult = await entityTranslator.Translate(context, entity).ConfigureAwait(false);
                    if (translateResult.IsTranslated)
                        return translateResult;
                }
            }

            return context.Result(entity);
        }
    }
}