namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSPI_850 :
        X12Layout
    {
        Segment<SPI> SpecificationIdentifier { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        SegmentList<MTX> Text { get; }
        
        LayoutList<LoopN1_2_850> LoopN1 { get; }
        
        LayoutList<LoopCB1_850> LoopCB1 { get; }
    }
}