namespace Machete
{
    public interface StringFormatResult<TSchema> :
        FormatResult<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// The formatted string result
        /// </summary>
        string Text { get; }
    }
}