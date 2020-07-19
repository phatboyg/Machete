namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopISSMap :
        X12LayoutMap<LoopISS, X12Entity>
    {
        public LoopISSMap()
        {
            Id = "Loop_ISS";
            Name = "Loop ISS";
            
            Segment(x => x.InvoiceShipmentSummary, 0);
            Segment(x => x.ProductOrItemDescription, 1);
        }
    }
}