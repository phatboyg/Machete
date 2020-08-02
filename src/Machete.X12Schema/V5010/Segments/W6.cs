namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W6 :
        X12Segment
    {
        Value<string> SpecialHandlingCode1 { get; }
        
        Value<string> SpecialHandlingCode2 { get; }
        
        Value<string> SpecialHandlingCode3 { get; }
        
        Value<string> SpecialHandlingCode4 { get; }
    }
}