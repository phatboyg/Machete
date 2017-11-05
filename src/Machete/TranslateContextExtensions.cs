namespace Machete
{
    using Values;


    public static class TranslateContextExtensions
    {
        /// <summary>
        /// Return an empty value of the specified type
        /// </summary>
        /// <param name="context"></param>
        /// <typeparam name="TSchema"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> Empty<TSchema, T>(this TranslateContext<TSchema> context)
            where TSchema : Entity
        {
            return Machete.Value.Empty<T>();
        }

        /// <summary>
        /// Return a constant value
        /// </summary>
        /// <param name="context"></param>
        /// <param name="value"></param>
        /// <typeparam name="TSchema"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> Value<TSchema, T>(this TranslateContext<TSchema> context, T value)
            where TSchema : Entity
        {
            return new ConstantValue<T>(value);
        }
    }
}