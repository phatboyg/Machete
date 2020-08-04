namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T945 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<W06> WarehouseShipmentIdentification { get; }
        
        LayoutList<Loop0100_945> Loop0100 { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<G61> Contact { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }
        
        Segment<W27> CarrierDetailsWarehouse { get; }
        
        SegmentList<W6> SpecialHandlingInformation { get; }
        
        Segment<W28> ConsolidationInformation { get; }
        
        SegmentList<W10> WarehouseAdditionalCarrierInformation { get; }
        
        LayoutList<Loop0200_945> Loop0200 { get; }
        
        LayoutList<Loop0300_945> Loop0300 { get; }
        
        Segment<W03> TotalShipmentInformation { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}