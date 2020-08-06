namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0300_940Map :
        X12LayoutMap<Loop0300_940, X12Entity>
    {
        public Loop0300_940Map()
        {
            Id = "Loop_0300_940";
            Name = "Loop 0300";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.MarksAndNumbersInformation, 1);
            Segment(x => x.DestinationQuantity, 2);
            Segment(x => x.PartyIdentification, 3);
            Segment(x => x.DateOrTime, 4);
            Segment(x => x.ExtendedReferenceInformation, 5);
            Layout(x => x.Loop0310, 6);
        }
    }
}