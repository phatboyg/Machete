namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopISR_1_870Map :
        X12LayoutMap<LoopISR_1_870, X12Entity>
    {
        public LoopISR_1_870Map()
        {
            Id = "Loop_ISR_1_870";
            Name = "Loop ISR";
            
            Segment(x => x.ItemStatusReport, 0);
            Segment(x => x.ProductOrItemDescription, 1);
            Segment(x => x.QuantityInformation, 2);
        }
    }
}