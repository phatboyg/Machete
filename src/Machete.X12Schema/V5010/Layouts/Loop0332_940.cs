namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0332_940 :
        X12Layout
    {
        Segment<LH1> HazardousIdentificationInformation { get; }
        
        SegmentList<LH2> HazardousClassificationInformation { get; }
        
        SegmentList<LH3> HazardousMaterialShippingName { get; }
        
        SegmentList<LFH> FreeformHazardousMaterialInformation { get; }
        
        SegmentList<LEP> EPARequiredData { get; }
        
        Segment<LH4> CanadianDangerousRequirements { get; }
        
        SegmentList<LHT> TransborderDangerousRequirements { get; }
        
        SegmentList<LHR> HazardousMaterialIdentifyingReferenceNumbers { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
    }
}