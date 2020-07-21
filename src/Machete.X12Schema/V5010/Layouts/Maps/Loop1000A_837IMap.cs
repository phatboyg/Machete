namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop1000A_837IMap :
        X12LayoutMap<Loop1000A_837I, X12Entity>
    {
        public Loop1000A_837IMap()
        {
            Id = "Loop_1000A_837I";
            Name = "Submitter Name";
            
            Segment(x => x.Submitter, 0);
            Segment(x => x.EDIContactInformation, 1);
        }
    }
}