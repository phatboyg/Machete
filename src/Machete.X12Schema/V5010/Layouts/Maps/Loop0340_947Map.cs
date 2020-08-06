namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0340_947Map :
        X12LayoutMap<Loop0340_947, X12Entity>
    {
        public Loop0340_947Map()
        {
            Id = "Loop_0340_947";
            Name = "Loop 0340";
            
            Segment(x => x.TypeOfFinancialAccountingData, 0);
            Segment(x => x.AccountingData, 1);
        }
    }
}