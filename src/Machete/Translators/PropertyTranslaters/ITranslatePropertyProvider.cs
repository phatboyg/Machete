namespace Machete.Translators.PropertyTranslaters
{
    using System.Threading.Tasks;


    public interface ITranslatePropertyProvider<TProperty, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
    {
        Task<TProperty> GetProperty(TranslateContext<TInput, TSchema> context);
    }
}