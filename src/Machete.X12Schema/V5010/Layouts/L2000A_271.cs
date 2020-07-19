namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000A_271 :
        X12Layout
    {
        Segment<HL> InformationSourceLevel { get; }
        
        SegmentList<AAA> RequestValidation { get; }
        
        Layout<L2100A_271> InformationSource { get; }
    }
}