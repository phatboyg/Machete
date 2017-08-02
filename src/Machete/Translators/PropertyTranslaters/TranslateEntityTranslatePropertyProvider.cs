namespace Machete.Translators.PropertyTranslaters
{
    using System.Threading.Tasks;
    using Entities.EntityProperties;


    public class TranslateEntityTranslatePropertyProvider<TEntity, TInput, TSchema> :
        ITranslatePropertyProvider<Entity<TEntity>, TInput, TSchema>
        where TInput : TSchema
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly ITranslator<TEntity, TSchema> _translator;
        readonly ITranslatePropertyProvider<Entity<TEntity>, TInput, TSchema> _provider;

        public TranslateEntityTranslatePropertyProvider(ITranslatePropertyProvider<Entity<TEntity>, TInput, TSchema> provider, ITranslator<TEntity, TSchema> translator)
        {
            _provider = provider;
            _translator = translator;
        }

        public async Task<Entity<TEntity>> GetProperty(TranslateContext<TInput, TSchema> context)
        {
            var entity = await _provider.GetProperty(context).ConfigureAwait(false);

            var entityContext = context.CreateContext(entity.Value);

            var result = await _translator.Translate(entityContext).ConfigureAwait(false);

            TEntity entityResult;
            if (result.TryGetEntity(0, out entityResult))
            {
                return new EntityProperty<TEntity>(entityResult);
            }

            return new EntityProperty<TEntity>();
        }
    }
}