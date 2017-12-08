namespace Machete.Translators.EntityTranslators
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

        public Task<TranslateResult<TSchema>> Translate(TranslateContext<TSchema> context, TSchema entity)
        {
            if (entity is TEntity input)
                return Translate(context.CreateContext(input));

            return Task.FromResult(context.NotTranslated<TEntity>());
        }

        public Task<TranslateResult<TSchema>> Translate(TranslateContext<TEntity, TSchema> context)
        {
            if (context.HasInput)
                return _filter != null
                    ? GetFilteredResult(context)
                    : GetResult(context);

            return Task.FromResult(context.Empty<TEntity>());
        }

        public ObserverHandle ConnectTranslatorObserver(ITranslatorObserver<TSchema> observer)
        {
            return _observers.Connect(observer);
        }

        async Task<TranslateResult<TSchema>> GetResult(TranslateContext<TEntity, TSchema> entityContext)
        {
            if (_observers.Count > 0)
                await _observers.PreTranslateEntity(entityContext.Input, entityContext).ConfigureAwait(false);

            var translateResult = entityContext.Empty<TEntity>();

            if (_observers.Count > 0)
                await _observers.PostTranslateEntity(translateResult, entityContext).ConfigureAwait(false);

            return translateResult;
        }

        async Task<TranslateResult<TSchema>> GetFilteredResult(TranslateContext<TEntity, TSchema> entityContext)
        {
            if (_observers.Count > 0)
                await _observers.PreTranslateEntity(entityContext.Input, entityContext).ConfigureAwait(false);

            var translateResult = await _filter(entityContext).ConfigureAwait(false)
                ? entityContext.Empty<TEntity>()
                : entityContext.Result(entityContext.Input);
            
            if (_observers.Count > 0)
                await _observers.PostTranslateEntity(translateResult, entityContext).ConfigureAwait(false);

            return translateResult;
        }
    }
}