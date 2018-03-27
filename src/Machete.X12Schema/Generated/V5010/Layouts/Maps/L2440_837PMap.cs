namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2440_837PMap :
        X12LayoutMap<L2440_837P, X12Entity>
    {
        public L2440_837PMap()
        {
            Id = "2440";
            Name = "Form Identification Code";
            
            Segment(x => x.Code, 0);
            Segment(x => x.SupportingDocumentation, 1, x => x.IsRequired());
        }
    }
}