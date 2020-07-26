namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopCB1_850Map :
        X12LayoutMap<LoopCB1_850, X12Entity>
    {
        public LoopCB1_850Map()
        {
            Id = "Loop_CB1_850";
            Name = "Loop CB1";
            
            Segment(x => x.ContractAndCostAccountingStandardsData, 0);
            Segment(x => x.ReferenceInformation, 1);
            Segment(x => x.DateOrTimeReference, 2);
            Segment(x => x.LeadTime, 3);
            Segment(x => x.Text, 4);
        }
    }
}