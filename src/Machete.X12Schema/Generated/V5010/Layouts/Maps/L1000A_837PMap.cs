namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L1000A_837PMap :
        X12LayoutMap<L1000A_837P, X12Entity>
    {
        public L1000A_837PMap()
        {
            Id = "1000A";
            Name = "Submitter Name";
            
            Segment(x => x.Name, 0, x => x.IsRequired());
            Segment(x => x.EDIContactInformation, 1, x => x.IsRequired());
        }
    }
}