namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420F_837PMap :
        X12LayoutMap<L2420F_837P, X12Entity>
    {
        public L2420F_837PMap()
        {
            Id = "2420F";
            Name = "Referring Provider Name";
                                    
            Segment(x => x.Name, 0);
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}