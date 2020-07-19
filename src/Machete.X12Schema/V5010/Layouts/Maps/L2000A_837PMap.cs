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
            
            Segment(x => x.BillingProviderHierarchicalLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("20")));
            Segment(x => x.BillingProviderSpecialtyInformation, 1);
            Segment(x => x.ForeignCurrencyInformation, 2);
            Layout(x => x.BillingProvider, 3);
            Layout(x => x.PayToAddress, 4);
            Layout(x => x.PayToPlan, 5);
        }
    }
}