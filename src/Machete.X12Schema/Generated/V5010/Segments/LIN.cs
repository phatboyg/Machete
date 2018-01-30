namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface LIN :
        X12Segment
    {
        Value<string> Qualifier { get; }

        Value<string> NationalDrugCode { get; }
    }
}