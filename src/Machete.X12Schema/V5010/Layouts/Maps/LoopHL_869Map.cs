namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopHL_869Map :
        X12LayoutMap<LoopHL_869, X12Entity>
    {
        public LoopHL_869Map()
        {
            Id = "Loop_HL_869";
            Name = "Loop HL";
            
            Segment(x => x.HierarchicalLevel, 0);
            Segment(x => x.PurchaseOrderReference, 1);
            Segment(x => x.DateOrTimeReference, 2);
            Segment(x => x.ItemIdentification, 3);
            Segment(x => x.ProductOrItemDescription, 4);
            Segment(x => x.Measurements, 5);
            Segment(x => x.QuantityInformation, 6);
            Segment(x => x.DemandDetail, 7);
            Segment(x => x.FurnishedGoodsAndServices, 8);
            Layout(x => x.LoopREF, 9);
            Layout(x => x.LoopN1, 10);
            Layout(x => x.LoopLM, 11);
            Layout(x => x.LoopFA1, 12);
        }
    }
}