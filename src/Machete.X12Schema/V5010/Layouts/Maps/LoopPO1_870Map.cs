namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPO1_870Map :
        X12LayoutMap<LoopPO1_870, X12Entity>
    {
        public LoopPO1_870Map()
        {
            Id = "Loop_PO1_870";
            Name = "Loop PO1";
            
            Segment(x => x.BaselineItemData, 0);
            Segment(x => x.Currency, 1);
            Segment(x => x.SublineItemDetail, 2);
            Segment(x => x.AdditionalItemDetail, 3);
            Segment(x => x.ProductOrItemDescription, 4);
            Segment(x => x.Measurements, 5);
            Segment(x => x.MarkingPackagingOrLoading, 6);
            Layout(x => x.LoopISR, 7);
            Layout(x => x.LoopLX, 8);
        }
    }
}