namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopFA1_858Map :
        X12LayoutMap<LoopFA1_858, X12Entity>
    {
        public LoopFA1_858Map()
        {
            Id = "Loop_FA1_858";
            Name = "Loop FA1";
            
            Segment(x => x.TypeOfFinancialAccountingData, 0);
            Segment(x => x.AccountingData, 1);
            Segment(x => x.WeightInformation, 2);
        }
    }
}