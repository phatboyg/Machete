namespace Machete.X12Schema.V5010.Segments
{
    using X12;


    public interface PKG :
        X12Segment
    {
        Value<string> ItemDescriptionType { get; }
        
        Value<string> PackagingCharacteristicCode { get; }
        
        Value<string> AgencyQualifierCode { get; }
        
        Value<string> PackagingDescriptionCode { get; }
        
        Value<string> Description { get; }
        
        Value<string> UnitLoadOptionCode { get; }
    }
}