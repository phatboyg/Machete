namespace Machete.Translators
{
    using System.Threading.Tasks;


    /// <summary>
    /// A simple fast copy of the source to the target
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public class CopyEntityTranslator<TEntity, TSchema> :
        IEntityTranslator<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly TranslateEntityFilter<TEntity, TSchema> _filter;

        public CopyEntityTranslator(TranslateEntityFilter<TEntity, TSchema> filter = null)
        {
            _filter = filter;
        }

        public async Task<TranslateResult<TSchema>> Translate(TranslateContext<TSchema> context, TSchema entity)
        {
            if (entity is TEntity)
            {
                var input = (TEntity) entity;

                if (_filter != null)
                {
                    var entityContext = context.CreateContext(input);

                    return await GetFilteredResult(entityContext, input).ConfigureAwait(false);
                }

                return context.Result(input);
            }

            return context.NotTranslated<TEntity>();
        }

        public Task<TranslateResult<TSchema>> Translate(TranslateContext<TEntity, TSchema> context)
        {
            if (context.HasInput && _filter != null)
                return GetFilteredResult(context, context.Input);

            return Task.FromResult(context.NotTranslated<TEntity>());
        }

        async Task<TranslateResult<TSchema>> GetFilteredResult(TranslateContext<TEntity, TSchema> entityContext, TEntity input)
        {
            if (await _filter(entityContext).ConfigureAwait(false))
                return entityContext.Result(input);

            return entityContext.NotTranslated(input);
        }
    }
}