namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2320_837I :
        X12Layout
    {
        Segment<SBR> SubscriberInformation { get; }
        
        SegmentList<CAS> ClaimLevelAdjustments { get; }
        
        Segment<AMT> CoordinationOfBenefitsPayerPaidAmount { get; }
        
        Segment<AMT> RemainingPatientLiability { get; }
        
        Segment<AMT> CoordinationOfBenefitsTotalNonCoveredAmount { get; }
        
        Segment<MOA> InsuranceCoverageInformation { get; }
        
        Segment<MOA> InpatientAdjudicationInformation { get; }
        
        Segment<MOA> OutpatientAdjudicationInformation { get; }
        
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