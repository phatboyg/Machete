namespace Machete.Configuration
{
    public interface ValidateResult
    {
        /// <summary>
        /// The result severity
        /// </summary>
        ValidateResultSeverity Severity { get; }

        /// <summary>
        /// The result message
        /// </summary>
        string Message { get; }

        /// <summary>
        /// The result key
        /// </summary>
        string Key { get; }

        /// <summary>
        /// The value associated with the key
        /// </summary>
        string Value { get; }
    }
}