namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0340_940Map :
        X12LayoutMap<Loop0340_940, X12Entity>
    {
        public Loop0340_940Map()
        {
            Id = "Loop_0340_940";
            Name = "Loop 0340";
            
            Segment(x => x.TypeOfFinancialAccountingData, 0);
            Segment(x => x.AccountingData, 1);
        }
    }
}