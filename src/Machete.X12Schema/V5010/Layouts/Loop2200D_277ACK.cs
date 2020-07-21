namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2200D_277ACK :
        X12Layout
    {
        Segment<TRN> TrackingNumber { get; }
        
        SegmentList<STC> StatusInformation { get; }
        
        Segment<REF> PayerClaimControlNumber { get; }
        
        Segment<REF> ClaimIdNumberForClearinghouseAndOtherTransmissionIntermediaries { get; }
        
        Segment<REF> InstitutionalBillTypeIdentification { get; }
        
        Segment<DTP> ClaimLevelServiceDate { get; }
        
        LayoutList<Loop2220D_277ACK> Loop2220D { get; }
    }
}