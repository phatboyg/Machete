namespace Machete.X12Schema.V5010
{
    using X12;


    public interface GF :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier1 { get; }
        
        Value<string> ReferenceIdentification1 { get; }
        
        Value<string> ContractNumber { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<string> ReferenceIdentificationQualifier2 { get; }
        
        Value<string> ReferenceIdentification2 { get; }
        
        Value<string> ReleaseNumber { get; }
        
        Value<string> ReferenceIdentificationQualifier3 { get; }
        
        Value<string> ReferenceIdentification3 { get; }
    }
}