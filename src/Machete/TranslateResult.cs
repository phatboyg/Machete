namespace Machete
{
    /// <summary>
    /// The result from a <see cref="ITranslator{TSchema}.Translate"/> method.
    /// </summary>
    /// <typeparam name="TSchema"></typeparam>
    public interface TranslateResult<TSchema> :
        EntityResult<TSchema>,
        IReadOnlyContext
        where TSchema : Entity
    {
        /// <summary>
        /// True if the translation was performed, otherwise false
        /// </summary>
        bool IsTranslated { get; }

        /// <summary>
        /// The entity result from which the input was parsed
        /// </summary>
        EntityResult<TSchema> Source { get; }
    }
}