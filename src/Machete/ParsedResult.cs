namespace Machete
{
    using Texts;


    public interface ParsedResult<in TSchema> :
        Parsed<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// The remaining text after parsing
        /// </summary>
        StreamText RemainingText { get; }

        /// <summary>
        /// The span for the remaining text, which wasn't parsed after the result
        /// </summary>
        TextSpan RemainingSpan { get; }
    }
}