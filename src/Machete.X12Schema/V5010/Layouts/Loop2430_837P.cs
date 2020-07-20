namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2430_837P :
        X12Layout
    {
        Segment<SVD> LineAdjudicationInformation { get; }
        
        SegmentList<CAS> LineAdjustment { get; }
        
        Segment<DTP> LineCheckOrRemittanceDate { get; }
        
        Segment<AMT> RemainingPatientLiability { get; }
    }
}