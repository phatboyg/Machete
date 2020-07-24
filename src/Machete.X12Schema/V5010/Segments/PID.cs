namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PID :
        X12Segment
    {
        Value<string> ItemDescriptionType { get; }
        
        Value<string> ProductOrProcessCharacteristicCode { get; }
        
        Value<string> AgencyQualifierCode { get; }
        
        Value<string> ProductDescriptionCode { get; }
        
        Value<string> Description { get; }
        
        Value<string> SurfaceLayerOrPositionCode { get; }
        
        Value<string> SourceSubQualifier { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
        
        Value<string> LanguageCode { get; }
    }
}