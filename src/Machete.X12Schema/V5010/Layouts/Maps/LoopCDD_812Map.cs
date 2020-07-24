namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopCDD_812Map :
        X12LayoutMap<LoopCDD_812, X12Entity>
    {
        public LoopCDD_812Map()
        {
            Id = "Loop_CDD_812";
            Name = "Credit/Debit Adjustment Detail";
            
            Segment(x => x.Name, 0);
            Segment(x => x.ItemIdentification, 1);
            Segment(x => x.ItemPhysicalDetails, 2);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 3);
            Segment(x => x.ReferenceIdentification, 4);
            Segment(x => x.DateTimeReference, 5);
            Segment(x => x.AdditionalNameInformation, 6);
        }
    }
}