namespace Machete.Translators
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class EntityTranslator<TEntity, TInput, TSchema> :
        IEntityTranslator<TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TEntity : TSchema
    {
        readonly IEntityFactory<TEntity> _entityFactory;
        readonly IReadOnlyList<IPropertyTranslator<TEntity, TInput, TSchema>> _propertyTranslaters;
        readonly TranslatorObservable<TSchema> _observers;

        public EntityTranslator(IEntityFactory<TEntity> entityFactory, IReadOnlyList<IPropertyTranslator<TEntity, TInput, TSchema>> propertyTranslaters)
        {
            _entityFactory = entityFactory;
            _propertyTranslaters = propertyTranslaters;

            _observers = new TranslatorObservable<TSchema>();
        }

        public async Task<TranslateResult<TSchema>> Translate(TranslateContext<TInput, TSchema> context)
        {
            var entity = _entityFactory.Create();

            if (_observers.Count > 0)
                await _observers.PreTranslateEntity(entity, context).ConfigureAwait(false);

            await Task.WhenAll(_propertyTranslaters.Select(x => x.Apply(entity, context))).ConfigureAwait(false);

            var translateResult = context.Result(entity);
            if (_observers.Count > 0)
                await _observers.PostTranslateEntity(translateResult, context).ConfigureAwait(false);

            return translateResult;
        }

        public Task<TranslateResult<TSchema>> Translate(TranslateContext<TSchema> context, TSchema entity)
        {
            if (entity is TInput input)
            {
                var entityContext = context.CreateContext(input);

                return Translate(entityContext);
            }

            return Task.FromResult(context.Empty<TSchema>());
        }

        public ObserverHandle ConnectTranslateObserver(ITranslatorObserver<TSchema> observer)
        {
            return _observers.Connect(observer);
        }
    }
}