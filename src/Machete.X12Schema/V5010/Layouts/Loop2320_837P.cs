namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2320_837P :
        X12Layout
    {
        Segment<SBR> SubscriberInformation { get; }
        
        SegmentList<CAS> ClaimLevelAdjustments { get; }
        
        Segment<AMT> CoordinationOfBenefitsPayerPaidAmount { get; }
        
        Segment<AMT> CoordinationOfBenefitsTotalNonCoveredAmount { get; }
        
        Segment<AMT> RemainingPatientLiability { get; }
        
        Segment<OI> InsuranceCoverageInformation { get; }
        
        Segment<MOA> OutpatientAdjudicationInformation { get; }
        
        Layout<Loop2330A_837P> Loop2330A { get; }
        
        Layout<Loop2330B_837P> Loop2330B { get; }
        
        LayoutList<Loop2330C_837P> Loop2330C { get; }
        
        Layout<Loop2330D_837P> Loop2330D { get; }
        
        Layout<Loop2330E_837P> Loop2330E { get; }
        
        Layout<Loop2330F_837P> Loop2330F { get; }
        
        Layout<Loop2330G_837P> Loop2330G { get; }
    }
}