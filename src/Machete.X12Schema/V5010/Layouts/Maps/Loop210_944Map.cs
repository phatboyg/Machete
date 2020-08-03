namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop210_944Map :
        X12LayoutMap<Loop210_944, X12Entity>
    {
        public Loop210_944Map()
        {
            Id = "Loop_210_944";
            Name = "Loop 210";

            Segment(x => x.ItemDetailForStockReceipt, 0);
            Segment(x => x.LineITemDetailDescription, 1);
            Segment(x => x.AdministrativeCommunicationsContact, 2);
            Segment(x => x.LineITemDetailPacking, 3);
            Layout(x => x.Loop211, 4);
        }
    }
}