namespace Machete.Configuration
{
    public interface IValidationResult
    {
        /// <summary>
        /// True if the configuration is valid
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// True if warnings (non-fatal) are present
        /// </summary>
        bool HasWarnings { get; }
    }
}