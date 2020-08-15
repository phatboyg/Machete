namespace Machete.X12Schema.V5010
{
    using X12;


    public interface H3 :
        X12Segment
    {
        Value<string> SpecialHandlingCode { get; }
        
        Value<string> SpecialHandlingDescription { get; }
        
        Value<string> ProtectiveServiceCode { get; }
        
        Value<string> VentInstructionCode { get; }
        
        Value<int> TariffApplicationCode { get; }
    }
}