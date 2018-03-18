namespace Machete.X12Schema.V5010.Layouts
{
    using X12;
    using X12.Schema.Segments;


    public interface L2000A_271 :
        X12Layout
    {
        Segment<HL> InformationSourceLevel { get; }
        
        SegmentList<AAA> RequestValidation { get; }
        
        Layout<L2100A_271> InformationSource { get; }
    }
}