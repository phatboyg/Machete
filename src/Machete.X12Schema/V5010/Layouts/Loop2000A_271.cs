namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000A_271 :
        X12Layout
    {
        Segment<HL> InformationSourceLevel { get; }
        
        SegmentList<AAA> RequestValidation { get; }
        
        Layout<Loop2100A_271> Loop2100A { get; }
    }
}