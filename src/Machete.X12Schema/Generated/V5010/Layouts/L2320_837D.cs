namespace Machete.X12Schema.V5010.Layouts
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
        
        LayoutList<L2330C_837D> ReferringProvider { get; }
        
        Layout<L2330D_837D> RenderingProvider { get; }
        
        Layout<L2330E_837D> SupervisingProvider { get; }
        
        Layout<L2330F_837D> BillingProvider { get; }
        
        Layout<L2330G_837D> ServiceFacilityLocation { get; }
        
        Layout<L2330H_837D> AssistantSurgeon { get; }
    }
}