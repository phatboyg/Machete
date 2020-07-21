namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2100B_277ACKMap :
        X12LayoutMap<Loop2100B_277ACK, X12Entity>
    {
        public Loop2100B_277ACKMap()
        {
            Id = "Loop_2100B_277_ACK";
            Name = "Information Receiver Name";
            
            Segment(x => x.InformationReceiverName, 0);
        }
    }
}