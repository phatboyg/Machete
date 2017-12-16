namespace Machete.Translators.PropertyTranslators.PropertyProviders
{
    using System.Threading.Tasks;
    using Entities.EntityProperties;


    public class TranslateEntityTranslatePropertyProvider<TEntity, TInput, TSchema> :
        ITranslatePropertyProvider<Entity<TEntity>, TInput, TSchema>
        where TInput : TSchema
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly IEntityTranslator<TEntity, TSchema> _translator;
        readonly ITranslatePropertyProvider<Entity<TEntity>, TInput, TSchema> _provider;

        public TranslateEntityTranslatePropertyProvider(ITranslatePropertyProvider<Entity<TEntity>, TInput, TSchema> provider, IEntityTranslator<TEntity, TSchema> translator)
        {
            _provider = provider;
            _translator = translator;
        }

        public async Task<Entity<TEntity>> GetProperty(TranslateContext<TInput, TSchema> context)
        {
            var entity = await _provider.GetProperty(context).ConfigureAwait(false);

            var entityContext = context.CreateContext(entity.Value);

            var result = await _translator.Translate(entityContext).ConfigureAwait(false);

            if (result.TryGetEntity<TEntity>(0, out var entityResult))
            {
                return new EntityProperty<TEntity>(entityResult);
            }

            return new EntityProperty<TEntity>();
        }
    }
}