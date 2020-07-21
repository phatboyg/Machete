namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000C_277ACKMap :
        X12LayoutMap<Loop2000C_277ACK, X12Entity>
    {
        public Loop2000C_277ACKMap()
        {
            Id = "Loop_2000C_277_ACK";
            Name = "Billing Provider of Service Detail";
            
            Segment(x => x.BillingProviderOfServiceLevel, 0,
                x =>
                    x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("19")));
            Layout(x => x.Loop2100C, 1);
            Layout(x => x.Loop2200C, 2);
        }
    }
}