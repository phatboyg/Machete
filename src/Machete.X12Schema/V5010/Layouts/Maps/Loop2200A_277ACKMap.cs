namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2200A_277ACKMap :
        X12LayoutMap<Loop2200A_277ACK, X12Entity>
    {
        public Loop2200A_277ACKMap()
        {
            Id = "Loop_2200A_277_ACK";
            Name = "Transmission Receipt Control Identifier";
            
            Segment(x => x.TransmissionReceiptControlIdentifier, 0, x => x.IsRequired());
            Segment(x => x.InformationSourceReceiptDate, 1,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("050")));
            Segment(x => x.InformationSourceProcessDate, 2,
                x => x.Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("009")));
        }
    }
}