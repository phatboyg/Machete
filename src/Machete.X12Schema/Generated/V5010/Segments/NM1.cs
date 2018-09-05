namespace Machete.X12Schema.V5010
{
    using X12;

    
    public interface NM1 :
        X12Segment
    {
        Value<string> EntityIdentifierCode { get; }

        Value<string> EntityTypeQualifier { get; }

        Value<string> LastNameOrOrganizationName { get; }

        Value<string> FirstName { get; }

        Value<string> MiddleName { get; }

        Value<string> NamePrefix { get; }

        Value<string> NameSuffix { get; }

        Value<string> IdentifierCodeQualifier { get; }

        Value<string> IdentifierCode { get; }
    }
}