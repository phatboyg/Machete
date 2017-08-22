namespace Machete.Translators
{
    using System.Threading.Tasks;


    /// <summary>
    /// Excludes all entities of the specified entity type from the result
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public class ExcludeEntityTranslator<TEntity, TSchema> :
        IEntityTranslator<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly TranslateEntityFilter<TEntity, TSchema> _filter;
        readonly TranslatorObservable<TSchema> _observers;

        public ExcludeEntityTranslator(TranslateEntityFilter<TEntity, TSchema> filter = null)
        {
            _filter = filter;

            _observers = new TranslatorObservable<TSchema>();
        }

        public async Task<TranslateResult<TSchema>> Translate(TranslateContext<TSchema> context, TSchema entity)
        {
            if (entity is TEntity)
            {
                var input = (TEntity) entity;

                var entityContext = context.CreateContext(input);

                if (_observers.Count > 0)
                    await _observers.PreTranslateEntity(input, entityContext).ConfigureAwait(false);

                TranslateResult<TSchema> translateResult;
                if (_filter != null)
                {
                    translateResult = await GetFilteredResult(entityContext, input).ConfigureAwait(false);
                }
                else
                    translateResult = context.Empty<TEntity>();

                if (_observers.Count > 0)
                    await _observers.PostTranslateEntity(translateResult, entityContext);

                return translateResult;
            }

            return context.NotTranslated<TEntity>();
        }

        public Task<TranslateResult<TSchema>> Translate(TranslateContext<TEntity, TSchema> context)
        {
            if (context.HasInput && _filter != null)
                return GetFilteredResult(context, context.Input);

            return Task.FromResult(context.Empty<TEntity>());
        }

        async Task<TranslateResult<TSchema>> GetFilteredResult(TranslateContext<TEntity, TSchema> entityContext, TEntity input)
        {
            if (await _filter(entityContext).ConfigureAwait(false))
                return entityContext.Empty<TEntity>();

            return entityContext.Result(input);
        }

        public ObserverHandle ConnectTranslateObserver(ITranslatorObserver<TSchema> observer)
        {
            return _observers.Connect(observer);
        }
    }
}