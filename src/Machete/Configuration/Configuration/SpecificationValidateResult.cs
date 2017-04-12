namespace Machete.Configuration
{
    using System.Text;


    public class SpecificationValidateResult :
        ValidateResult
    {
        public SpecificationValidateResult(ValidateResultSeverity severity, string message, string key, string value)
        {
            Severity = severity;
            Key = key;
            Value = value;
            Message = message;
        }

        public SpecificationValidateResult(ValidateResultSeverity severity, string message, string key)
        {
            Severity = severity;
            Key = key;
            Message = message;
        }

        public SpecificationValidateResult(ValidateResultSeverity severity, string message)
        {
            Severity = severity;
            Message = message;
        }

        public ValidateResultSeverity Severity { get; }
        public string Key { get; }
        public string Value { get; }
        public string Message { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Severity);
            sb.Append(": ");
            sb.Append(Message);

            if (!string.IsNullOrWhiteSpace(Key))
            {
                sb.Append(' ');
                sb.Append('(');
                sb.Append(Key);
                if (!string.IsNullOrWhiteSpace(Value))
                {
                    sb.Append('=');
                    sb.Append(Value);
                }
                sb.Append(')');
            }
            return sb.ToString();
        }
    }
}