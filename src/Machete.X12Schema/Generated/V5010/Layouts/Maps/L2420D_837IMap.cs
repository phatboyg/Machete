namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420D_837IMap :
        X12LayoutMap<L2420D_837I, X12Entity>
    {
        public L2420D_837IMap()
        {
            Id = "2420D";
            Name = "Rendering Provider Name";
            
            Segment(x => x.ReferringProvider, 0);
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}