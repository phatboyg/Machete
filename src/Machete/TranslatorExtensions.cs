namespace Machete
{
    using System.Threading.Tasks;
    using Translators.TranslateContexts;


    public static class TranslatorExtensions
    {
        public static Task<EntityResult<TSchema>> Translate<TInput, TSchema>(this ITranslator<TInput, TSchema> translator, EntityResult<TSchema> result,  Result<Cursor<TSchema>, TInput> input)
            where TSchema : Entity
            where TInput : TSchema
        {
            var context = new EntityTranslateContext<TInput, TSchema>(result, input);

            return translator.Translate(context);
        }
    }
}