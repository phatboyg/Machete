namespace Machete.X12Schema.V5010
{
    using X12;


    public interface CB1 :
        X12Segment
    {
        Value<string> AcquisitionDataCode { get; }
        
        Value<string> FinancingTypeCode { get; }
    }
}