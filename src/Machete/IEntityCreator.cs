namespace Machete
{
    using System.Threading.Tasks;


    public interface IEntityCreator<TSchema> :
        ITranslatorObserverConnector<TSchema>
        where TSchema : Entity
    {
        Task<TranslateResult<TSchema>> Translate(TranslateContext<TSchema> context);
    }

    public interface IEntityCreator<T, TSchema> :
        IEntityCreator<TSchema>
        where TSchema : Entity
    {
        Task<TranslateResult<TSchema>> Translate(TranslateContext<T, TSchema> context);
    }
}