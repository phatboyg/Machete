namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310F_837IMap :
        X12LayoutMap<L2310F_837I, X12Entity>
    {
        public L2310F_837IMap()
        {
            Id = "2310F";
            Name = "Referring Provider Name";
            
            Segment(x => x.ReferringProvider, 0);
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}