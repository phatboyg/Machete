namespace Machete.X12Schema.V5010
{
    using X12;

    
    public interface REF :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }

        Value<string> Description { get; }
        
        Value<ReferenceIdentifier> ReferenceIdentifier { get; }
    }
}