namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T945Map :
        X12LayoutMap<T945, X12Entity>
    {
        public T945Map()
        {
            Id = "T945";
            Name = "945 Warehouse Shipping Advice";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.WarehouseShipmentIdentification, 2);
            Layout(x => x.Loop0100, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.Contact, 5);
            Segment(x => x.DateOrTime, 6);
            Segment(x => x.NotesOrSpecialInstruction, 7);
            Segment(x => x.CarrierDetailsWarehouse, 8);
            Segment(x => x.SpecialHandlingInformation, 9);
            Segment(x => x.ConsolidationInformation, 10);
            Segment(x => x.WarehouseAdditionalCarrierInformation, 11);
            Layout(x => x.Loop0200, 12);
            Layout(x => x.Loop0300, 13);
            Segment(x => x.TotalShipmentInformation, 14);
            Segment(x => x.TransactionSetTrailer, 15);
            Segment(x => x.FunctionalGroupTrailer, 16);
        }
    }
}