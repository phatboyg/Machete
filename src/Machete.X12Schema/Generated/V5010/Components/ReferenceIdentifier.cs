namespace Machete.X12Schema.V5010
{
    using X12;


    public interface ReferenceIdentifier :
        X12Component
    {
        Value<string> ReferenceIdentificationQualifier1 { get; }
        
        Value<string> ReferenceIdentification1 { get; }
        
        Value<string> ReferenceIdentificationQualifier2 { get; }
        
        Value<string> ReferenceIdentification2 { get; }
        
        Value<string> ReferenceIdentificationQualifier3 { get; }
        
        Value<string> ReferenceIdentification3 { get; }
    }
}