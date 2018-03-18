namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2100C_271 :
        X12Layout
    {
        Segment<NM1> Subscriber { get; }
        
        SegmentList<REF> AdditionalIdentification { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<AAA> RequestValidation { get; }
        
        SegmentList<PRV> ProviderInformation { get; }
        
        SegmentList<DMG> DemographicInformation { get; }
        
        SegmentList<INS> SubscriberRelationship { get; }
        
        SegmentList<HI> HealthcareDiagnosisCode { get; }
        
        SegmentList<DTP> SubscriberDate { get; }
        
        SegmentList<MPI> MilitaryPersonnelInformation { get; }
        
        LayoutList<L2110C_271> EligibilityOrBenefitInformation { get; }
    }
}