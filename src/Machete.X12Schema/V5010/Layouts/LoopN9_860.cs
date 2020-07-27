namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN9_860 :
        X12Layout
    {
        Segment<N9> ExtendedReferenceInformation { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        SegmentList<MTX> Text { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<EFI> ElectronicFormatIdentification { get; }
    }
}