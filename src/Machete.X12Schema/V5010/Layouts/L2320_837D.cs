namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2320_837D :
        X12Layout
    {
        Segment<SBR> SubscriberInformation { get; }
        
        SegmentList<CAS> ClaimLevelAdjustments { get; }
        
        Segment<AMT> CoordinationOfBenefitsPayerPaidAmount { get; }
        
        Segment<AMT> RemainingPatientLiability { get; }
        
        Segment<AMT> CoordinationOfBenefitsTotalNonCoveredAmount { get; }
        
        Segment<MOA> InsuranceCoverageInformation { get; }
        
        Segment<MOA> OutpatientAdjudicationInformation { get; }
        
        Layout<L2330A_837D> Subscriber { get; }
        
        Layout<L2330B_837D> Payer { get; }
        
        LayoutList<L2330C_837D> PayerReferringProvider { get; }
        
        Layout<L2330D_837D> PayerRenderingProvider { get; }
        
        Layout<L2330E_837D> PayerSupervisingProvider { get; }
        
        Layout<L2330F_837D> PayerBillingProvider { get; }
        
        Layout<L2330G_837D> PayerServiceFacilityLocation { get; }
        
        Layout<L2330H_837D> PayerAssistantSurgeon { get; }
    }
}