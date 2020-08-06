namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T947 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<W15> WarehouseAdjustmentIdentification { get; }
        
        LayoutList<Loop0100_947> Loop0100 { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<G61> Contact { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }
        
        LayoutList<Loop0200_947> Loop0200 { get; }
        
        LayoutList<Loop0300_947> Loop0300 { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}