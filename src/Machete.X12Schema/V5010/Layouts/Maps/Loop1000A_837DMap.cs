namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1000A_837DMap :
        X12LayoutMap<Loop1000A_837D, X12Entity>
    {
        public Loop1000A_837DMap()
        {
            Id = "Loop_1000A_837D";
            Name = "Submitter Name";
            
            Segment(x => x.Submitter, 0);
            Segment(x => x.EDIContactInformation, 1);
        }
    }
}