namespace Machete.X12Schema.V5010
{
    using X12;


    public interface SI :
        X12Segment
    {
        Value<string> AgencyQualifierCode { get; }
        
        Value<string> ServiceCharacteristicsQualifier1 { get; }
        
        Value<string> ProductOrServiceId1 { get; }
        
        Value<string> ServiceCharacteristicsQualifier2 { get; }
        
        Value<string> ProductOrServiceId2 { get; }
        
        Value<string> ServiceCharacteristicsQualifier3 { get; }
        
        Value<string> ProductOrServiceId3 { get; }
        
        Value<string> ServiceCharacteristicsQualifier4 { get; }
        
        Value<string> ProductOrServiceId4 { get; }
        
        Value<string> ServiceCharacteristicsQualifier5 { get; }
        
        Value<string> ProductOrServiceId5 { get; }
        
        Value<string> ServiceCharacteristicsQualifier6 { get; }
        
        Value<string> ProductOrServiceId6 { get; }
        
        Value<string> ServiceCharacteristicsQualifier7 { get; }
        
        Value<string> ProductOrServiceId7 { get; }
        
        Value<string> ServiceCharacteristicsQualifier8 { get; }
        
        Value<string> ProductOrServiceId8 { get; }
        
        Value<string> ServiceCharacteristicsQualifier9 { get; }
        
        Value<string> ProductOrServiceId9 { get; }
        
        Value<string> ServiceCharacteristicsQualifier10 { get; }
        
        Value<string> ProductOrServiceId10 { get; }
    }
}