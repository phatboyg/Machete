namespace Machete
{
    using System.Threading.Tasks;


    public interface ITranslator<in TInput, TSchema>
        where TInput : TSchema
        where TSchema : Entity
    {
        Task<EntityResult<TSchema>> Translate(TranslateContext<TInput, TSchema> context);
    }
}