namespace Machete.Translators.EntityTranslators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PropertyTranslators;


    public class EntityTranslator<TEntity, TInput, TSchema> :
        IEntityTranslator<TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TEntity : TSchema
    {
        readonly string _translateName;
        readonly IEntityFactory<TEntity> _entityFactory;
        readonly TranslatorObservable<TSchema> _observers;
        readonly IReadOnlyList<IPropertyTranslator<TEntity, TInput, TSchema>> _propertyTranslaters;

        public EntityTranslator(string translateName, IEntityFactory<TEntity> entityFactory, IReadOnlyList<IPropertyTranslator<TEntity, TInput, TSchema>> propertyTranslaters)
        {
            _translateName = translateName;
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

        public ObserverHandle ConnectTranslatorObserver(ITranslatorObserver<TSchema> observer)
        {
            return _observers.Connect(observer);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("translate {0} (entity: {1}, type: translate", _translateName, typeof(TEntity).Name);
            if (typeof(TInput) != typeof(TEntity))
                sb.AppendFormat(", input: {0}", typeof(TInput).Name);
            sb.AppendLine(") {");

            foreach (var propertyTranslater in _propertyTranslaters)
            {
                var strings = propertyTranslater.ToString().Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
                foreach (var s in strings)
                {
                    sb.Append("  ");
                    sb.AppendLine(s.Trim('\n', '\r'));
                }
            }

            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}