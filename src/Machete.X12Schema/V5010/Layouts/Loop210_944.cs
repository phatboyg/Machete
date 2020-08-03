namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop210_944 :
        X12Layout
    {
        Segment<W07> ItemDetailForStockReceipt { get; }
        
        SegmentList<G69> LineITemDetailDescription { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<W20> LineITemDetailPacking { get; }
        
        LayoutList<Loop211_944> Loop211 { get; }
    }
}