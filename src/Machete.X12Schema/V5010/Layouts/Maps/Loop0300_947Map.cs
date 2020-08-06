namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0300_947Map :
        X12LayoutMap<Loop0300_947, X12Entity>
    {
        public Loop0300_947Map()
        {
            Id = "Loop_0300_947";
            Name = "Loop 0300";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.MarksAndNumbersInformation, 1);
            Segment(x => x.ExtendedReferenceInformation, 2);
            Segment(x => x.ContractSummary, 3);
            Segment(x => x.MonetaryAmountInformation, 4);
            Segment(x => x.DateOrTime, 4);
            Layout(x => x.Loop0310, 5);
            Layout(x => x.Loop0320, 6);
            Layout(x => x.Loop0330, 7);
        }
    }
}