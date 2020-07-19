namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000C_277ACKMap :
        X12LayoutMap<L2000C_277ACK, X12Entity>
    {
        public L2000C_277ACKMap()
        {
            Id = "2000C";
            Name = "Billing Provider of Service Detail";
            
            Segment(x => x.BillingProviderOfServiceLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("19")));
            Layout(x => x.BillingProviderName, 1);
            Layout(x => x.ProviderOfServiceInformationTraceIdentifier, 2);
        }
    }
}