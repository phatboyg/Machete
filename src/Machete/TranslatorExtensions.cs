namespace Machete
{
    using System.Threading.Tasks;
    using Translators.TranslateContexts;


    public static class TranslatorExtensions
    {
        public static Task<TranslateResult<TSchema>> Translate<TInput, TSchema>(this IEntityTranslator<TInput, TSchema> translator, EntityResult<TSchema> result,
            Result<Cursor<TSchema>, TInput> input)
            where TSchema : Entity
            where TInput : TSchema
        {
            var context = new EntityTranslateContext<TInput, TSchema>(result, input);

            return translator.Translate(context);
        }

        public static Task<TranslateResult<TSchema>> Translate<TSchema>(this ITranslator<TSchema> translator, EntityResult<TSchema> result)
            where TSchema : Entity
        {
            var context = new SchemaTranslateContext<TSchema>(result);

            return translator.Translate(context);
        }

        public static Task<TranslateResult<TSchema>> Translate<TSchema>(this IEntityCreator<TSchema> translator)
            where TSchema : Entity
        {
            var context = new CreateTranslateContext<TSchema>();

            return translator.Translate(context);
        }

        public static Task<TranslateResult<TSchema>> Translate<TSchema>(this IEntityCreator<TSchema> translator, EntityResult<TSchema> result)
            where TSchema : Entity
        {
            var context = new CreateTranslateContext<TSchema>(result);

            return translator.Translate(context);
        }

        public static Task<TranslateResult<TSchema>> Translate<TSchema>(this ICreator<TSchema> translator, EntityResult<TSchema> result)
            where TSchema : Entity
        {
            var context = new CreateTranslateContext<TSchema>(result);

            return translator.Translate(context);
        }

        public static Task<TranslateResult<TSchema>> Translate<TSchema>(this ICreator<TSchema> translator)
            where TSchema : Entity
        {
            var context = new CreateTranslateContext<TSchema>();

            return translator.Translate(context);
        }
    }
}