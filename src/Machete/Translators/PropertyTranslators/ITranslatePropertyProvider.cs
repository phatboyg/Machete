namespace Machete.Translators.PropertyTranslators
{
    using System.Threading.Tasks;


    public interface ITranslatePropertyProvider<TProperty, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
    {
        Task<TProperty> GetProperty(TranslateContext<TInput, TSchema> context);
    }


    public interface ITranslatePropertyProvider<TProperty, TSchema>
        where TSchema : Entity
    {
        Task<TProperty> GetProperty(TranslateContext<TSchema> context);
    }
}