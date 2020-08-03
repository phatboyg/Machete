namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0360_945Map :
        X12LayoutMap<Loop0360_945, X12Entity>
    {
        public Loop0360_945Map()
        {
            Id = "Loop_0360_945";
            Name = "Loop 0360";
            
            Segment(x => x.TypeOfFinancialAccountingData, 0);
            Segment(x => x.AccountingData, 1);
        }
    }
}