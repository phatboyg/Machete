namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopISS_810Map :
        X12LayoutMap<LoopISS_810, X12Entity>
    {
        public LoopISS_810Map()
        {
            Id = "Loop_ISS_810";
            Name = "Loop ISS";
            
            Segment(x => x.InvoiceShipmentSummary, 0);
            Segment(x => x.ProductOrItemDescription, 1);
        }
    }
}