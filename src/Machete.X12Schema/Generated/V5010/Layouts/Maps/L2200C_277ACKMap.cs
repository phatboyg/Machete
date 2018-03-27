namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2200C_277ACKMap :
        X12LayoutMap<L2200C_277ACK, X12Entity>
    {
        public L2200C_277ACKMap()
        {
            Id = "2200C";
            Name = "Provider of Service Information Trace Identifier";
            
            Segment(x => x.ProviderOfServiceInformationTraceIdentifier, 0);
            Segment(x => x.StatusInformation, 1);
            Segment(x => x.SecondaryIdentifier, 2);
            Segment(x => x.TotalAcceptedQuantity, 3);
            Segment(x => x.TotalRejectedQuantity, 4);
            Segment(x => x.TotalAcceptedAmount, 5);
            Segment(x => x.TotalRejectedAmount, 6);
        }
    }
}