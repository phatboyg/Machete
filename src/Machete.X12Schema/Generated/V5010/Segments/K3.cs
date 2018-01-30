namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface K3 :
        X12Segment
    {
        Value<string> FixedFormatInformation { get; }
    }
}