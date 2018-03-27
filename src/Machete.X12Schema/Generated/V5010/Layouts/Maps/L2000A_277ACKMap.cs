namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000A_277ACKMap :
        X12LayoutMap<L2000A_277ACK, X12Entity>
    {
        public L2000A_277ACKMap()
        {
            Id = "277ACK";
            Name = "Information Source Detail";
            
            Segment(x => x.InformationSourceLevel, 0, x => x.IsRequired());
            Layout(x => x.InformationSourceName, 1);
            Layout(x => x.TransmissionReceiptControlIdentifier, 2);
        }
    }
}