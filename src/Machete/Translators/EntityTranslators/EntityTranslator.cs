namespace Machete.Translators.EntityTranslators
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PropertyTranslaters;


    public class EntityTranslator<TEntity, TInput, TSchema> :
        IEntityTranslator<TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TEntity : TSchema
    {
        readonly IEntityFactory<TEntity> _entityFactory;
        readonly TranslatorObservable<TSchema> _observers;
        readonly IReadOnlyList<IPropertyTranslator<TEntity, TInput, TSchema>> _propertyTranslaters;

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
                return Translate(context.CreateContext(input));

            return Task.FromResult(context.Empty<TSchema>());
        }

        public ObserverHandle ConnectTranslateObserver(ITranslatorObserver<TSchema> observer)
        {
            return _observers.Connect(observer);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("translate (entity: {0}, type: translate", typeof(TEntity).Name);
            if (typeof(TInput) != typeof(TEntity))
                sb.AppendFormat(", input: {0}", typeof(TInput).Name);
            sb.AppendLine(") {");
            
            foreach (var propertyTranslater in _propertyTranslaters)
            {
                sb.Append(propertyTranslater);
            }

            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}