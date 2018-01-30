namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface CR7 :
        X12Segment
    {
        Value<string> DisciplineTypeCode { get; }

        Value<int> TotalVisitsPriorToRecertDate { get; }

        Value<int> TotalVisitsProjectedDuringCertPeriod { get; }
    }
}