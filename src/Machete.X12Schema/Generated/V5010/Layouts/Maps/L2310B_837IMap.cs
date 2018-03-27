namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310B_837IMap :
        X12LayoutMap<L2310B_837I, X12Entity>
    {
        public L2310B_837IMap()
        {
            Id = "2310B";
            Name = "Operating Physician Name";
            
            Segment(x => x.RenderingProvider, 0);
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}