namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T944 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<W17> WarehouseReceiptIdentification { get; }
        
        LayoutList<Loop0100_944> Loop0100 { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<G61> Contact { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }
        
        Segment<W08> ReceiptCarrierInformation { get; }
        
        SegmentList<W18> ProbeTemperatures { get; }
        
        SegmentList<G08> PalletReceiptDisposition { get; }
        
        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        LayoutList<Loop0200_944> Loop0200 { get; }
        
        Segment<W14> TotalReceiptInformation { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}