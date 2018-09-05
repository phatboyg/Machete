namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2320_837P :
        X12Layout
    {
        Segment<SBR> SubscriberInfo { get; }
        
        SegmentList<CAS> ClaimLevelAdjustments { get; }
        
        Segment<AMT> COBPayerPaidAmount { get; }
        
        Segment<AMT> COBTotalNonCoveredAmount { get; }
        
        Segment<AMT> RemainingPatientLiability { get; }
        
        Segment<OI> InsuranceCoverageInfo { get; }
        
        Segment<MOA> OutpatientAdjudicationInfo { get; }
        
        Layout<L2330A_837P> OtherSubscriberName { get; }
        
        Layout<L2330B_837P> OtherPayerName { get; }
        
        LayoutList<L2330C_837P> OtherPayerReferringProvider { get; }
        
        Layout<L2330D_837P> OtherPayerRenderingProvider { get; }
        
        Layout<L2330E_837P> OtherPayerServiceFacilityLocation { get; }
        
        Layout<L2330F_837P> OtherPayerSupervisingProvider { get; }
        
        Layout<L2330G_837P> OtherPayerBillingProvider { get; }
    }
}