namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000A_837DMap :
        X12LayoutMap<L2000A_837D, X12Entity>
    {
        public L2000A_837DMap()
        {
            Id = "2000A";
            Name = "Billing Provider Hierarchical Level";
            
            Segment(x => x.BillingProviderHierarchicalLevel, 0, x => x.IsRequired());
            Segment(x => x.BillingProviderSpecialtyInformation, 1);
            Segment(x => x.ForeignCurrencyInformation, 2);
            Layout(x => x.BillingProviderName, 3);
            Layout(x => x.PayToAddress, 4);
            Layout(x => x.PayToPlan, 5);
        }
    }
}