namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330I_837IMap :
        X12LayoutMap<L2330I_837I, X12Entity>
    {
        public L2330I_837IMap()
        {
            Id = "2330I";
            Name = "Other Payer Billing Provider";
            
            Segment(x => x.BillingProvider, 0);
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}