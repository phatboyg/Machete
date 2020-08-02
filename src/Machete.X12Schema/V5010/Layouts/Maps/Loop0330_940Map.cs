namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0330_940Map :
        X12LayoutMap<Loop0330_940, X12Entity>
    {
        public Loop0330_940Map()
        {
            Id = "Loop_0330_940";
            Name = "Loop 0330";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.ExtendedReferenceInformation, 1);
            Segment(x => x.DateOrTime, 2);
            Segment(x => x.PartyIdentification, 3);
            Segment(x => x.DestinationQuantity, 4);
            Layout(x => x.Loop0331, 5);
            Layout(x => x.Loop0332, 6);
        }
    }
}