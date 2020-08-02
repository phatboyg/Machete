namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T940Map :
        X12LayoutMap<T940, X12Entity>
    {
        public T940Map()
        {
            Id = "T940";
            Name = "940 Warehouse Shipping Order";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.ShippingOrderIdentification, 2);
            Layout(x => x.Loop0100, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.Contact, 5);
            Segment(x => x.DateOrTime, 6);
            Segment(x => x.NotesOrSpecialInstruction, 7);
            Segment(x => x.EquipmentAndTemperature, 8);
            Segment(x => x.WarehouseCarrierInformation, 9);
            Segment(x => x.SpecialHandlingInformation, 10);
            Segment(x => x.RouteInformation, 11);
            Segment(x => x.RailShipmentInformation, 12);
            Layout(x => x.Loop0150, 13);
            Layout(x => x.Loop0200, 14);
            Layout(x => x.Loop0300, 15);
            Segment(x => x.TotalShippingOrder, 16);
            Segment(x => x.TransactionSetTrailer, 17);
            Segment(x => x.FunctionalGroupTrailer, 18);
        }
    }
}