namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0310_945 :
        X12Layout
    {
        Segment<W12> WarehouseItemDetail { get; }
        
        SegmentList<G69> LineITemDetailDescription { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<AMT> MonetaryAmountInformation { get; }
        
        SegmentList<R4> PortOrTerminal { get; }
        
        Segment<W27> CarrierDetailsWarehouse { get; }
        
        LayoutList<Loop0320_945> Loop0320 { get; }
        
        SegmentList<G72> AllowanceOrCharge { get; }
        
        LayoutList<Loop0330_945> Loop0330 { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<Loop0340_940> Loop0340 { get; }
        
        Segment<LE> LoopTrailer { get; }
        
        LayoutList<Loop0360_945> Loop0360 { get; }
    }
}