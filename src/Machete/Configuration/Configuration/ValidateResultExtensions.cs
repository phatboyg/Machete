namespace Machete.Configuration
{
    public static class ValidateResultExtensions
    {
        public static ValidateResult Null(this ISpecification specification, string key)
        {
            return new SpecificationValidateResult(ValidateResultSeverity.Error, "Must not be null", key);
        }

        public static ValidateResult Error(this ISpecification specification, string message)
        {
            return new SpecificationValidateResult(ValidateResultSeverity.Error, message);
        }

        public static ValidateResult Error(this ISpecification specification, string message, string key)
        {
            return new SpecificationValidateResult(ValidateResultSeverity.Error, message, key);
        }

        public static ValidateResult Error(this ISpecification specification, string message, string key, string value)
        {
            return new SpecificationValidateResult(ValidateResultSeverity.Error, message, key, value);
        }

        public static ValidateResult Warning(this ISpecification specification, string message)
        {
            return new SpecificationValidateResult(ValidateResultSeverity.Warning, message);
        }

        public static ValidateResult Warning(this ISpecification specification, string message, string key)
        {
            return new SpecificationValidateResult(ValidateResultSeverity.Warning, message, key);
        }

        public static ValidateResult Warning(this ISpecification specification, string message, string key, string value)
        {
            return new SpecificationValidateResult(ValidateResultSeverity.Warning, message, key, value);
        }

        public static ValidateResult Information(this ISpecification specification, string message)
        {
            return new SpecificationValidateResult(ValidateResultSeverity.Information, message);
        }

        public static ValidateResult Information(this ISpecification specification, string message, string key)
        {
            return new SpecificationValidateResult(ValidateResultSeverity.Information, message, key);
        }

        public static ValidateResult Information(this ISpecification specification, string message, string key, string value)
        {
            return new SpecificationValidateResult(ValidateResultSeverity.Information, message, key, value);
        }

        public static ValidateResult WithParentKey(this ValidateResult result, string parentKey)
        {
            string key = $"{parentKey}.{result.Key}";

            return new SpecificationValidateResult(result.Severity, result.Message, key, result.Value);
        }
    }
}