namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2110_835 :
        X12Layout
    {
        Segment<SVC> ServicePaymentInformation { get; }
        
        SegmentList<DTM> ServiceDate { get; }
        
        SegmentList<CAS> ServiceAdjustment { get; }
        
        SegmentList<REF> ServiceIdentification { get; }
        
        Segment<REF> LineItemControlNumber { get; }
        
        SegmentList<REF> RenderingProviderInformation { get; }
        
        SegmentList<REF> HealthcarePolicyIdentification { get; }
        
        SegmentList<AMT> ServiceSupplementalAmount { get; }
        
        SegmentList<QTY> ServiceSupplementalQuantity { get; }
        
        SegmentList<LQ> HealthcareRemarkCodes { get; }
    }
}