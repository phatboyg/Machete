namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2330B_837P :
        X12Layout
    {
        Segment<NM1> Payer { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInfo { get; }
        
        Segment<DTP> ClaimCheckOrRemittanceDate { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
        
        Segment<REF> PriorAuthorizationNumber { get; }
        
        Segment<REF> ReferralNumber { get; }
        
        Segment<REF> ClaimAdjustmentIndicator { get; }
        
        Segment<REF> ClaimControlNumber { get; }
    }
}