namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330G_837PMap :
        X12LayoutMap<L2330G_837P, X12Entity>
    {
        public L2330G_837PMap()
        {
            Id = "2330G";
            Name = "Other Payer Billing Provider";
            
            Segment(x => x.BillingProvider, 0);
            Segment(x => x.SecondaryIdentification, 1, x => x.IsRequired());
        }
    }
}