namespace Machete.Translators.EntityTranslators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PropertyTranslators;


    public class EntityCreator<TEntity, TSchema> :
        IEntityCreator<TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly string _name;
        readonly IEntityFactory<TEntity> _entityFactory;
        readonly TranslatorObservable<TSchema> _observers;
        readonly IReadOnlyList<IPropertyTranslator<TEntity, TSchema>> _propertyTranslaters;

        public EntityCreator(string name, IEntityFactory<TEntity> entityFactory, IReadOnlyList<IPropertyTranslator<TEntity, TSchema>> propertyTranslaters)
        {
            _name = name;
            _entityFactory = entityFactory;
            _propertyTranslaters = propertyTranslaters;

            _observers = new TranslatorObservable<TSchema>();
        }

        public async Task<TranslateResult<TSchema>> Translate(TranslateContext<TSchema> context)
        {
            var entity = _entityFactory.Create();

            if (_observers.Count > 0)
                await _observers.PreCreateEntity(entity, context).ConfigureAwait(false);

            await Task.WhenAll(_propertyTranslaters.Select(x => x.Apply(entity, context))).ConfigureAwait(false);

            var translateResult = context.Result(entity);
            if (_observers.Count > 0)
                await _observers.PostCreateEntity(translateResult, context).ConfigureAwait(false);

            return translateResult;
        }

        public ObserverHandle ConnectTranslatorObserver(ITranslatorObserver<TSchema> observer)
        {
            return _observers.Connect(observer);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("create {0} (entity: {1}, type: create", _name, typeof(TEntity).Name);
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