namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000A_837PMap :
        X12LayoutMap<L2000A_837P, X12Entity>
    {
        public L2000A_837PMap()
        {
            Id = "2000A";
            Name = "Subscriber Hierarchical Level";
            
            Segment(x => x.BillingProviderHierarchicalLevel, 0, x => x.IsRequired());
            Segment(x => x.BillingProviderSpecialtyInformation, 1);
            Segment(x => x.ForeignCurrencyInformation, 2);
            Layout(x => x.BillingProviderName, 3);
        }
    }
}