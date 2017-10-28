namespace Machete.Translators.EntityTranslators
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
        readonly TranslatorObservable<TSchema> _observers;

        public CopyEntityTranslator(TranslateEntityFilter<TEntity, TSchema> filter = null)
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

            return Task.FromResult(context.NotTranslated<TEntity>());
        }

        public ObserverHandle ConnectTranslateObserver(ITranslatorObserver<TSchema> observer)
        {
            return _observers.Connect(observer);
        }

        async Task<TranslateResult<TSchema>> GetResult(TranslateContext<TEntity, TSchema> entityContext)
        {
            if (_observers.Count > 0)
                await _observers.PreTranslateEntity(entityContext.Input, entityContext).ConfigureAwait(false);

            var translateResult = entityContext.Result(entityContext.Input);

            if (_observers.Count > 0)
                await _observers.PostTranslateEntity(translateResult, entityContext).ConfigureAwait(false);

            return translateResult;
        }

        async Task<TranslateResult<TSchema>> GetFilteredResult(TranslateContext<TEntity, TSchema> entityContext)
        {
            if (_observers.Count > 0)
                await _observers.PreTranslateEntity(entityContext.Input, entityContext).ConfigureAwait(false);

            var translateResult = await _filter(entityContext).ConfigureAwait(false)
                ? entityContext.Result(entityContext.Input)
                : entityContext.NotTranslated(entityContext.Input);

            if (_observers.Count > 0)
                await _observers.PostTranslateEntity(translateResult, entityContext).ConfigureAwait(false);

            return translateResult;
        }
    }
}