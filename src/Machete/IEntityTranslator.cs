namespace Machete
{
    using System.Threading.Tasks;


    public interface IEntityTranslator<TInput, TSchema> :
        IEntityTranslator<TSchema>
        where TInput : TSchema
        where TSchema : Entity
    {
        Task<TranslateResult<TSchema>> Translate(TranslateContext<TInput, TSchema> context);
    }


    public interface IEntityTranslator<TSchema> :
        ITranslatorObserverConnector<TSchema>
        where TSchema : Entity
    {
        Task<TranslateResult<TSchema>> Translate(TranslateContext<TSchema> context, TSchema entity);
    }
}