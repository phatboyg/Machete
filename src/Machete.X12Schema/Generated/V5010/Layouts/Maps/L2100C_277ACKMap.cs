namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100C_277ACKMap :
        X12LayoutMap<L2100C_277ACK, X12Entity>
    {
        public L2100C_277ACKMap()
        {
            Id = "2100C";
            Name = "Billing Provider Name";
            
            Segment(x => x.BillingPRoviderName, 0, x => x.IsRequired());
        }
    }
}