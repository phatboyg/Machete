namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LHE :
        X12Segment
    {
        Value<string> HazardousMaterialShippingName { get; }
        
        Value<string> HazardousPlacardNotation { get; }
        
        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
        
        Value<string> ReportableQuantityCode { get; }
    }
}