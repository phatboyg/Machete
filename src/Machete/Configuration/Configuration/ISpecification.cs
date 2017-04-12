namespace Machete.Configuration
{
    using System.Collections.Generic;


    public interface ISpecification
    {
        /// <summary>
        /// Validate the specification to ensure it is properly configured
        /// </summary>
        /// <returns>The validation results for this specification</returns>
        IEnumerable<ValidateResult> Validate();
    }
}