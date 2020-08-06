namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T947Map :
        X12LayoutMap<T947, X12Entity>
    {
        public T947Map()
        {
            Id = "T947";
            Name = "947 Warehouse Inventory Adjustment Advice";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.WarehouseAdjustmentIdentification, 2);
            Layout(x => x.Loop0100, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.Contact, 5);
            Segment(x => x.DateOrTime, 6);
            Segment(x => x.NotesOrSpecialInstruction, 7);
            Layout(x => x.Loop0200, 8);
            Layout(x => x.Loop0300, 9);
            Segment(x => x.TransactionSetTrailer, 10);
            Segment(x => x.FunctionalGroupTrailer, 11);
        }
    }
}