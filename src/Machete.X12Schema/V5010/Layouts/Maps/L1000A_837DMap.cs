namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L1000A_837DMap :
        X12LayoutMap<Loop1000A_837D, X12Entity>
    {
        public L1000A_837DMap()
        {
            Id = "1000A";
            Name = "Submitter Name";
            
            Segment(x => x.Submitter, 0, x => x.IsRequired());
            Segment(x => x.EDIContactInformation, 1, x => x.IsRequired());
        }
    }
}