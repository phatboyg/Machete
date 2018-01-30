namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface MIA :
        X12Segment
    {
        Value<int> CoveredDaysOrVisitDays { get; }

        Value<int> LifetimeReserveDays { get; }

        Value<int> LifetimePsychiatricDays { get; }

        Value<decimal> DrgAmount { get; }

        Value<string> RemarkCode1 { get; }

        Value<decimal> DisproportionateShare { get; }

        Value<decimal> MspPassThrough { get; }

        Value<decimal> PpsCapital { get; }

        Value<decimal> PpsCapitalFspDrg { get; }

        Value<decimal> PpsCapitalHspDrg { get; }

        Value<decimal> PpsCapitalDshDrg { get; }

        Value<decimal> OldCapital { get; }

        Value<decimal> PpsCapitalIme { get; }

        Value<decimal> PpsOperatingHospitalSpecificDrg { get; }

        Value<int> CostReportDayCount { get; }

        Value<decimal> PpsOperatingFederalSpecificDrg { get; }

        Value<decimal> PpsCapitalOutlier { get; }

        Value<decimal> IndirectTeaching { get; }

        Value<decimal> NonpayableProfessionalComponent { get; }

        Value<string> RemarkCode2 { get; }

        Value<string> RemarkCode3 { get; }

        Value<string> RemarkCode4 { get; }

        Value<string> RemarkCode5 { get; }

        Value<decimal> PpsCapitalException { get; }
    }
}