namespace Machete
{
    using System.Threading.Tasks;


    public interface IEntityCreator<TSchema> :
        ITranslatorObserverConnector<TSchema>
        where TSchema : Entity
    {
        Task<TranslateResult<TSchema>> Translate(TranslateContext<TSchema> context);
    }
}