namespace Machete.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class ValidationResult :
        IValidationResult
    {
        readonly ValidateResult[] _results;

        public ValidationResult(IEnumerable<ValidateResult> results)
        {
            _results = results.ToArray();
        }

        bool IValidationResult.IsValid => _results.All(x => x.Severity != ValidateResultSeverity.Error);
        bool IValidationResult.HasWarnings => _results.Any(x => x.Severity == ValidateResultSeverity.Warning);

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _results.Select(x => x.ToString()));
        }
    }
}