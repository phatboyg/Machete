namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0200_943 :
        X12Layout
    {
        Segment<W04> ItemDetailTotal { get; }
        
        SegmentList<W04> LineItemDetailDescription { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }

        SegmentList<W20> LineItemDetailPacking { get; }
    }
}