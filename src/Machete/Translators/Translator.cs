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

            TSchema entity;
            while (context.Source.TryGetEntity(index, out entity))
            {
                var entityResult = await TranslateEntity(context, entity).ConfigureAwait(false);

                results.Add(entityResult);

                index++;
            }

            return results.ToResult();
        }

        async Task<TranslateResult<TSchema>> TranslateEntity(TranslateContext<TSchema> context, TSchema entity)
        {
            var entityType = entity.GetType();

            var interfaceTypes = entityType.GetTypeInfo().GetInterfaces();
            if (interfaceTypes.Length == 0)
                return context.Result(entity, entityType);

            foreach (var interfaceType in interfaceTypes)
            {
                IEntityTranslator<TSchema> entityTranslator;
                if (_entityTranslators.TryGetValue(interfaceType, out entityTranslator))
                {
                    var translateResult = await entityTranslator.Translate(context, entity).ConfigureAwait(false);
                    if (translateResult.IsTranslated)
                        return translateResult;
                }
            }

            return context.Result(entity);
        }

        public ObserverHandle ConnectTranslateObserver(ITranslatorObserver<TSchema> observer)
        {
            throw new NotImplementedException();
        }
    }
}