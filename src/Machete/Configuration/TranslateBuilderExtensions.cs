namespace Machete
{
    using TranslatorConfiguration;
    using Translators.PropertyTranslators;


    public static class TranslateBuilderExtensions
    {
        /// <summary>
        ///     Replace all existing translators for the property with the specified translator
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="propertyName"></param>
        /// <param name="translator"></param>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TSchema"></typeparam>
        public static void Replace<TResult, TInput, TSchema>(this IEntityTranslatorBuilder<TResult, TInput, TSchema> builder, string propertyName,
            IPropertyTranslator<TResult, TInput, TSchema> translator)
            where TResult : TSchema
            where TInput : TSchema
            where TSchema : Entity
        {
            builder.Clear(propertyName);

            builder.Add(propertyName, translator);
        }
    }
}