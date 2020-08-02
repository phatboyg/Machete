namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T940 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<W05> ShippingOrderIdentification { get; }
        
        LayoutList<Loop0100_940> Loop0100 { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<G61> Contact { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }
        
        Segment<W09> EquipmentAndTemperature { get; }
        
        Segment<W66> WarehouseCarrierInformation { get; }
        
        SegmentList<W6> SpecialHandlingInformation { get; }
        
        SegmentList<R2> RouteInformation { get; }
        
        SegmentList<BNX> RailShipmentInformation { get; }
        
        LayoutList<Loop0150_940> Loop0150 { get; }
        
        LayoutList<Loop0200_940> Loop0200 { get; }
        
        LayoutList<Loop0300_940> Loop0300 { get; }
        
        Segment<W76> TotalShippingOrder { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}