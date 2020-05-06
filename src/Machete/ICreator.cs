namespace Machete
{
    using System.Threading.Tasks;


    public interface ICreator<TSchema> :
        ITranslatorObserverConnector<TSchema>
        where TSchema : Entity
    {
        Task<TranslateResult<TSchema>> Translate(TranslateContext<TSchema> context);
    }
}