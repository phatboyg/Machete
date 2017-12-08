namespace Machete
{
    public interface TranslateValueContext<out TValue, TInput, TSchema> :
        TranslateContext<TInput, TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// The value of the input property
        /// </summary>
        TValue Value { get; }

        /// <summary>
        /// True if the input property has a value
        /// </summary>
        bool HasValue { get; }
    }
}