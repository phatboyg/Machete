namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CR7Map :
        X12SegmentMap<CR7, X12Entity>
    {
        public CR7Map()
        {
            Id = "CR7";
            Name = "Home Health Care Plan Information";
            
            Value(x => x.DisciplineTypeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.TotalVisitsPriorToRecertDate, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.TotalVisitsProjectedDuringCertPeriod, 3, x => x.FixedLength(1).IsRequired());
        }
    }
}