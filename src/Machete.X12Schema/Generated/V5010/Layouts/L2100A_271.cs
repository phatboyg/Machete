namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2100A_271 :
        X12Layout
    {
        Segment<HL> InformationSourceLevel { get; }
        
        SegmentList<PER> ContactInformation { get; }
        
        SegmentList<AAA> RequestValidation { get; }
    }
}