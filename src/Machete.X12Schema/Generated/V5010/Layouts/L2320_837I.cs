namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2320_837I :
        X12Layout
    {
        Segment<SBR> SubscriberInfo { get; }
        
        SegmentList<CAS> ClaimLevelAdjustments { get; }
        
        Segment<AMT> COBPayerPaidAmount { get; }
        
        Segment<AMT> RemainingPatientLiability { get; }
        
        Segment<AMT> COBTotalNonCoveredAmount { get; }
        
        Segment<MOA> InsuranceCoverageInfo { get; }
        
        Segment<MOA> InpatientAdjudicationInfo { get; }
        
        Segment<MOA> OutpatientAdjudicationInfo { get; }
        
        Layout<L2330A_837I> Subscriber { get; }
        
        Layout<L2330B_837I> Payer { get; }
        
        LayoutList<L2330C_837I> PayerAttendingProvider { get; }
        
        Layout<L2330D_837I> PayerOperatingPhysician { get; }
        
        Layout<L2330E_837I> PayerOtherOperatingPhysician { get; }
        
        Layout<L2330F_837I> PayerServiceFacilityLocation { get; }
        
        Layout<L2330G_837I> PayerRenderingProvider { get; }
        
        Layout<L2330H_837I> PayerReferringProvider { get; }
        
        Layout<L2330I_837I> PayerBillingProvider { get; }
    }
}