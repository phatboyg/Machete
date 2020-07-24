namespace Machete.X12Schema.V5010
{
    using X12;


    public interface R4 :
        X12Segment
    {
        Value<string> PortOrTerminalFunctionCode { get; }
        
        Value<string> LocationQualifier { get; }
        
        Value<string> LocationIdentifier { get; }
        
        Value<string> PortName { get; }
        
        Value<string> CountryCode { get; }
        
        Value<string> TerminalName { get; }
        
        Value<string> PierNumber { get; }
        
        Value<string> StateOrProvinceCode { get; }
    }
}