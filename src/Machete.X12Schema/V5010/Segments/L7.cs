namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface L7 :
        X12Segment
    {
        Value<string> LadingLineItemNumber { get; }
        
        Value<string> TariffAgencyCode { get; }
        
        Value<string> TariffNumber { get; }
        
        Value<string> TariffSectionNumber { get; }
        
        Value<string> TariffItemNumber { get; }
        
        Value<string> TariffItemPart { get; }
        
        Value<string> FreightClassCode { get; }
        
        Value<string> TariffSupplementIdentifier { get; }
        
        Value<string> ExParte { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> RateBasisNumber { get; }
        
        Value<string> TariffColumn { get; }
        
        Value<string> TariffDistance { get; }
        
        Value<string> DistanceQualifier { get; }
        
        Value<string> CityName { get; }
        
        Value<string> StateOrProvinceCode { get; }
    }
}