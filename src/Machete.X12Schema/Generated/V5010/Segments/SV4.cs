namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface SV4 :
        X12Segment
    {
        Value<string> PrescriptionNumber { get; }
    }
}