namespace Machete
{
    using System.Threading.Tasks;


    /// <summary>
    /// A translator which can be used on any <see cref="EntityResult{TSchema}"/>.
    /// </summary>
    /// <typeparam name="TSchema"></typeparam>
    public interface ITranslator<TSchema> :
        ITranslatorObserverConnector<TSchema>
        where TSchema : Entity
    {
        Task<TranslateResult<TSchema>> Translate(TranslateContext<TSchema> context);
    }
}