namespace Machete.X12Schema.V5010
{
    using X12;


    public interface CS :
        X12Segment
    {
        Value<string> ContractNumber { get; }

        Value<string> ChangeOrderSequenceNumber { get; }

        Value<string> ReleaseNumber { get; }

        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<string> SpecialServicesCode1 { get; }
        
        Value<string> FreeOnBoardPointCode { get; }

        Value<decimal> Percent1 { get; }

        Value<decimal> Percent2 { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<string> TermsTypeCode1 { get; }
        
        Value<string> SpecialServicesCode2 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<decimal> UnitPrice { get; }
        
        Value<string> TermsTypeCode2 { get; }
        
        Value<string> YesNoConditionOrResponseCode1 { get; }
        
        Value<string> YesNoConditionOrResponseCode2 { get; }
    }
}