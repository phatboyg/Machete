namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface TS2 :
        X12Segment
    {
        Value<decimal> TotalDrgAmount { get; }

        Value<decimal> TotalFederalSpecificAmount { get; }

        Value<decimal> TotalHospitalSpecificAmount { get; }

        Value<decimal> TotalDisproportionateShareAmount { get; }

        Value<decimal> TotalCapitalAmount { get; }

        Value<decimal> TotalIndirectMedicalEducationAmount { get; }

        Value<int> TotalOutlierDayCount { get; }

        Value<decimal> TotalDayOutlierAmount { get; }

        Value<decimal> TotalCostOutlierAmount { get; }

        Value<int> AverageDrgLengthOfStay { get; }

        Value<int> TotalDischargeCount { get; }

        Value<int> TotalCostReportDayCount { get; }

        Value<int> TotalCoveredDayCount { get; }

        Value<int> TotalNoncoveredDayCount { get; }

        Value<decimal> TotalMspPassThroughAmount { get; }

        Value<decimal> AverageDrgWeight { get; }

        Value<decimal> TotalPpsCapitalFspDrgAmount { get; }

        Value<decimal> TotalPpsCapitalHspDrgAmount { get; }

        Value<decimal> TotalPpsDshDrgAmount { get; }
    }
}