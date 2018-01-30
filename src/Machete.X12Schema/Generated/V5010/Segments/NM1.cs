namespace Machete.X12Schema.V5010
{
    using X12;

    
    public interface NM1 :
        X12Segment
    {
        Value<string> EntityIdCode { get; }

        Value<string> EntityTypeQualifier { get; }

        Value<string> LastNameOrOrganizationName { get; }

        Value<string> FirstName { get; }

        Value<string> MiddleName { get; }

        Value<string> NameSuffix { get; }

        Value<string> IdCodeQualifier { get; }

        Value<string> IdCode { get; }
    }
}