namespace Machete.X12Schema.V5010
{
    using X12;


    public interface V1 :
        X12Segment
    {
        Value<string> VesselCode { get; }
        
        Value<string> VesselName { get; }
        
        Value<string> CountryCode { get; }
        
        Value<string> FlightOrVoyageNumber { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> VesselRequirementCode { get; }
        
        Value<string> VesselTypeCode { get; }
        
        Value<string> VesselCodeQualifier { get; }
        
        Value<string> TransportationMethodOrTypeCode { get; }
    }
}