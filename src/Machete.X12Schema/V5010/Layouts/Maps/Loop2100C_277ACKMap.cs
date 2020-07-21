namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100C_277ACKMap :
        X12LayoutMap<Loop2100C_277ACK, X12Entity>
    {
        public Loop2100C_277ACKMap()
        {
            Id = "Loop_2100C_277_ACK";
            Name = "Billing Provider Name";
            
            Segment(x => x.BillingProvider, 0);
        }
    }
}