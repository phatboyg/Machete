namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class TS2Map : X12SegmentMap<TS2, X12Entity>
    {
        public TS2Map()
        {
            Id = "TS2";
            Name = "Transaction Supplemental Statistics";
            Value(x => x.TotalDrgAmount, 1, x => x.MinLength(1));
            Value(x => x.TotalFederalSpecificAmount, 2, x => x.MinLength(1));
            Value(x => x.TotalHospitalSpecificAmount, 3, x => x.MinLength(1));
            Value(x => x.TotalDisproportionateShareAmount, 4, x => x.MinLength(1));
            Value(x => x.TotalCapitalAmount, 5, x => x.MinLength(1));
            Value(x => x.TotalIndirectMedicalEducationAmount, 6, x => x.MinLength(1));
            Value(x => x.TotalOutlierDayCount, 7, x => x.MinLength(1));
            Value(x => x.TotalDayOutlierAmount, 8, x => x.MinLength(1));
            Value(x => x.TotalCostOutlierAmount, 9, x => x.MinLength(1));
            Value(x => x.AverageDrgLengthOfStay, 10, x => x.MinLength(1));
            Value(x => x.TotalDischargeCount, 11, x => x.MinLength(1));
            Value(x => x.TotalCostReportDayCount, 12, x => x.MinLength(1));
            Value(x => x.TotalCoveredDayCount, 13, x => x.MinLength(1));
            Value(x => x.TotalNoncoveredDayCount, 14, x => x.MinLength(1));
            Value(x => x.TotalMspPassThroughAmount, 15, x => x.MinLength(1));
            Value(x => x.AverageDrgWeight, 16, x => x.MinLength(1));
            Value(x => x.TotalPpsCapitalFspDrgAmount, 17, x => x.MinLength(1));
            Value(x => x.TotalPpsCapitalHspDrgAmount, 18, x => x.MinLength(1));
            Value(x => x.TotalPpsDshDrgAmount, 19, x => x.MinLength(1));
        }
    }
}