namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class MIAMap : X12SegmentMap<MIA, X12Entity>
    {
        public MIAMap()
        {
            Id = "MIA";
            Name = "Medicare Inpatient Adjudication";
            Value(x => x.CoveredDaysOrVisitDays, 1, x => x.MinLength(1).IsRequired());
            Value(x => x.LifetimeReserveDays, 2, x => x.MinLength(1));
            Value(x => x.LifetimePsychiatricDays, 3, x => x.MinLength(1));
            Value(x => x.DrgAmount, 4, x => x.MinLength(1));
            Value(x => x.RemarkCode1, 5, x => x.MinLength(1).MaxLength(30));
            Value(x => x.DisproportionateShare, 6, x => x.MinLength(1));
            Value(x => x.MspPassThrough, 7, x => x.MinLength(1));
            Value(x => x.PpsCapital, 8, x => x.MinLength(1));
            Value(x => x.PpsCapitalFspDrg, 9, x => x.MinLength(1));
            Value(x => x.PpsCapitalHspDrg, 10, x => x.MinLength(1));
            Value(x => x.PpsCapitalDshDrg, 11, x => x.MinLength(1));
            Value(x => x.OldCapital, 12, x => x.MinLength(1));
            Value(x => x.PpsCapitalIme, 13, x => x.MinLength(1));
            Value(x => x.PpsOperatingHospitalSpecificDrg, 14, x => x.MinLength(1));
            Value(x => x.CostReportDayCount, 15, x => x.MinLength(1));
            Value(x => x.PpsOperatingFederalSpecificDrg, 16, x => x.MinLength(1));
            Value(x => x.PpsCapitalOutlier, 17, x => x.MinLength(1));
            Value(x => x.IndirectTeaching, 18, x => x.MinLength(1));
            Value(x => x.NonpayableProfessionalComponent, 19, x => x.MinLength(1));
            Value(x => x.RemarkCode2, 20, x => x.MinLength(1).MaxLength(30));
            Value(x => x.RemarkCode3, 21, x => x.MinLength(1).MaxLength(30));
            Value(x => x.RemarkCode4, 22, x => x.MinLength(1).MaxLength(30));
            Value(x => x.RemarkCode5, 23, x => x.MinLength(1).MaxLength(30));
            Value(x => x.PpsCapitalException, 24, x => x.MinLength(1));
        }
    }
}