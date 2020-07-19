namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface AK1 :
        X12Segment
    {
        Value<string> FunctionalIdCode { get; }
        
        Value<string> GroupCtrlNumber { get; }
        
        Value<string> VerReleaseIdCode { get; }
    }
}
