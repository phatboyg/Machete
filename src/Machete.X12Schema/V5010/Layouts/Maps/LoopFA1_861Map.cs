namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopFA1_861Map :
        X12LayoutMap<LoopFA1_861, X12Entity>
    {
        public LoopFA1_861Map()
        {
            Id = "Loop_FA1_861";
            Name = "Loop FA1";
            
            Segment(x => x.TypeOfFinancialAccountingData, 0);
            Segment(x => x.AccountingData, 1);
        }
    }
}