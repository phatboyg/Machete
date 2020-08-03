namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T943Map :
        X12LayoutMap<T943, X12Entity>
    {
        public T943Map()
        {
            Id = "T943";
            Name = "943 Warehouse Stock Transfer Shipment Advice";

            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.WarehouseShipmentIdentification, 2);
            Layout(x => x.Loop0100, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.Contact, 5);
            Segment(x => x.DateOrTime, 6);
            Segment(x => x.NotesOrSpecialInstruction, 7);
            Segment(x => x.CarrierDetailsWarehouse, 8);
            Segment(x => x.ConsolidationInformation, 9);
            Segment(x => x.WarehouseAdditionalCarrierInformation, 10);
            Layout(x => x.Loop0200, 11);
            Segment(x => x.TotalShipmentInformation, 12);
            Segment(x => x.TransactionSetTrailer, 13);
            Segment(x => x.FunctionalGroupTrailer, 14);
        }
    }
}