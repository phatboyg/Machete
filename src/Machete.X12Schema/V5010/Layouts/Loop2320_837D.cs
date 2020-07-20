namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2320_837D :
        X12Layout
    {
        Segment<SBR> SubscriberInformation { get; }
        
        SegmentList<CAS> ClaimLevelAdjustments { get; }
        
        Segment<AMT> CoordinationOfBenefitsPayerPaidAmount { get; }
        
        Segment<AMT> RemainingPatientLiability { get; }
        
        Segment<AMT> CoordinationOfBenefitsTotalNonCoveredAmount { get; }
        
        Segment<MOA> InsuranceCoverageInformation { get; }
        
        Segment<MOA> OutpatientAdjudicationInformation { get; }
        
        Layout<Loop2330A_837D> Loop2330A { get; }
        
        Layout<Loop2330B_837D> Loop2330B { get; }
        
        LayoutList<Loop2330C_837D> Loop2330C { get; }
        
        Layout<Loop2330D_837D> Loop2330D { get; }
        
        Layout<Loop2330E_837D> Loop2330E { get; }
        
        Layout<Loop2330F_837D> Loop2330F { get; }
        
        Layout<Loop2330G_837D> Loop2330G { get; }
        
        Layout<Loop2330H_837D> Loop2330H { get; }
    }
}