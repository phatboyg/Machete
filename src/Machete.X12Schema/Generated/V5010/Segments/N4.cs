namespace Machete.X12Schema.V5010
{
    using X12;

    
    public interface N4 :
        X12Segment
    {
        Value<string> CityName { get; }

        Value<string> StateOrProvinceCode { get; }

        Value<string> PostalCode { get; }

        Value<string> CountryCode { get; }

        Value<string> LocationQualifier { get; }

        Value<string> LocationIdentifier { get; }
        
        Value<string> CountrySubdivisionCode { get; }
    }
}