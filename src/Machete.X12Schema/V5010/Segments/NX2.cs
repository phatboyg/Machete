namespace Machete.X12Schema.V5010
{
    using X12;


    public interface NX2 :
        X12Segment
    {
        Value<string> AddressComponentQualifier { get; }
        
        Value<string> AddressInformation { get; }
        
        Value<string> CountyDesignator { get; }
    }
}