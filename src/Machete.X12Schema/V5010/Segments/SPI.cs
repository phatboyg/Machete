namespace Machete.X12Schema.V5010
{
    using X12;


    public interface SPI :
        X12Segment
    {
        Value<string> SecurityLevelCode1 { get; }
        
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
        
        Value<string> EntityTitle { get; }
        
        Value<string> EntityPurpose { get; }
        
        Value<string> EntityStatusCode { get; }
        
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> ReportTypeCode { get; }
        
        Value<string> SecurityLevelCode2 { get; }
        
        Value<string> AgencyQualifierCode { get; }
        
        Value<string> SourceSubqualifier { get; }
        
        Value<int> AssignedNumber { get; }
        
        Value<string> CertificationTypeCode { get; }
        
        Value<string> ProposalDataDetailIdentifierCode { get; }
        
        Value<string> HierarchicalStructureCode { get; }
    }
}