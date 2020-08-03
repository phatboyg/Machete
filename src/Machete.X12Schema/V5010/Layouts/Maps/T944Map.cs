namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T944Map :
        X12LayoutMap<T944, X12Entity>
    {
        public T944Map()
        {
            Id = "T944";
            Name = "944 Warehouse Stock Transfer Receipt Advice";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.WarehouseReceiptIdentification, 2);
            Layout(x => x.Loop0100, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.Contact, 5);
            Segment(x => x.DateOrTime, 6);
            Segment(x => x.NotesOrSpecialInstruction, 7);
            Segment(x => x.ReceiptCarrierInformation, 8);
            Segment(x => x.ProbeTemperatures, 9);
            Segment(x => x.PalletReceiptDisposition, 10);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 11);
            Layout(x => x.Loop0200, 12);
            Segment(x => x.TotalReceiptInformation, 13);
            Segment(x => x.TransactionSetTrailer, 14);
            Segment(x => x.FunctionalGroupTrailer, 15);
        }
    }
}