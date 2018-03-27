namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330D_837PMap :
        X12LayoutMap<L2330D_837P, X12Entity>
    {
        public L2330D_837PMap()
        {
            Id = "2330D";
            Name = "Other Payer Rendering Provider";
            
            Segment(x => x.RenderingProvider, 0);
            Segment(x => x.SecondaryIdentification, 1, x => x.IsRequired());
        }
    }
}