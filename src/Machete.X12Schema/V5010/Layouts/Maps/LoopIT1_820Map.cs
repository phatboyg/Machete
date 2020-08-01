namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopIT1_820Map :
        X12LayoutMap<LoopIT1_820, X12Entity>
    {
        public LoopIT1_820Map()
        {
            Id = "Loop_IT1_820";
            Name = "Loop IT1";
            
            Segment(x => x.BaselineItemData, 0);
            Segment(x => x.RateAmountsOrPercents, 1);
            Segment(x => x.QuantityInformation, 2);
            Layout(x => x.LoopREF, 3);
            Layout(x => x.LoopSAC, 4);
            Layout(x => x.LoopSLN, 5);
        }
    }
}