namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSLNMap :
        X12LayoutMap<LoopSLN, X12Entity>
    {
        public LoopSLNMap()
        {
            Id = "Loop_SLN";
            Name = "Loop SLN";
            
            Segment(x => x.SublineItemDetail, 0);
            Segment(x => x.DateOrTimeReference, 1);
            Segment(x => x.ReferenceInformation, 2);
            Segment(x => x.ProductOrItemDescription, 3);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 4);
            Segment(x => x.Commodity, 5);
            Segment(x => x.TaxInformation, 6);
        }
    }
}