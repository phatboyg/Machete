namespace Machete.X12Schema.V5010
{
    using X12;


    public interface V5 :
        X12Segment
    {
        Value<string> VesselCodeQualifier { get; }
        
        Value<string> VesselCode { get; }
        
        Value<string> CountryCode { get; }
    }
}