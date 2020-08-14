namespace Machete.X12Schema.V5010
{
    using X12;


    public interface E4 :
        X12Segment
    {
        Value<string> CityName { get; }
        
        Value<string> StateOrProvinceCode { get; }
        
        Value<string> PostalCode { get; }
        
        Value<string> CountryCode { get; }
    }
}