namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2100D_271 :
        X12Layout
    {
        Segment<NM1> Dependent { get; }
        
        SegmentList<REF> AdditionalIdentification { get; }
        
        Segment<N3> Address { get; }
        
        SegmentList<AAA> RequestValidation { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<PRV> ProviderInformation { get; }
        
        SegmentList<DMG> DemographicInformation { get; }
        
        SegmentList<INS> DependentRelationship { get; }
        
        SegmentList<HI> HealthcareDiagnosisCode { get; }
        
        SegmentList<DTP> DependentDate { get; }
        
        SegmentList<MPI> MilitaryPersonnelInformation { get; }
        
        LayoutList<L2110D_271> EligibilityOrBenefitInformation { get; }
    }
}