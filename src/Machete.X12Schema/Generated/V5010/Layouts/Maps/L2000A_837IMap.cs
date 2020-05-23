﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000A_837IMap :
        X12LayoutMap<L2000A_837I, X12Entity>
    {
        public L2000A_837IMap()
        {
            Id = "2000A";
            Name = "Billing Provider Hierarchical Level";
            
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