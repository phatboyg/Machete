namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2100D_270 :
        X12Layout
    {
        Segment<NM1> Dependent { get; }
        
        SegmentList<REF> AdditionalIdentification { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<PRV> ProviderInformation { get; }
        
        SegmentList<DMG> DemographicInformation { get; }
        
        SegmentList<INS> DependentRelationship { get; }
        
        SegmentList<HI> HealthcareDiagnosisCode { get; }
        
        SegmentList<DTP> DependentDate { get; }
        
        LayoutList<L2110D_270> EligibilityOrBenefitInquiry { get; }
    }
}