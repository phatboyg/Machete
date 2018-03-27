namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330C_837PMap :
        X12LayoutMap<L2330C_837P, X12Entity>
    {
        public L2330C_837PMap()
        {
            Id = "2330C";
            Name = "Other Payer Referring Provider";
            
            Segment(x => x.ReferringProvider, 0);
            Segment(x => x.SecondaryIdentification, 1, x => x.IsRequired());
        }
    }
}