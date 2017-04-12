namespace Machete.Configuration
{
    using System;


    public static class ValidationExtensions
    {
        public static IValidationResult ValidateConfiguration(this ISpecification specification)
        {
            IValidationResult result = new ValidationResult(specification.Validate());
            if (!result.IsValid)
                throw new ConfigurationValidationException($"The configuration contained error(s){Environment.NewLine}{result}");

            return result;
        }
    }
}