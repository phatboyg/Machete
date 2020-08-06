namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0330_947Map :
        X12LayoutMap<Loop0330_947, X12Entity>
    {
        public Loop0330_947Map()
        {
            Id = "Loop_0330_947";
            Name = "Loop 0330";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.ExtendedReferenceInformation, 1);
            Segment(x => x.DateOrTime, 2);
            Segment(x => x.PartyIdentification, 3);
            Layout(x => x.Loop0331, 4);
        }
    }
}