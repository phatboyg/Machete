namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2200A_277ACKMap :
        X12LayoutMap<L2200A_277ACK, X12Entity>
    {
        public L2200A_277ACKMap()
        {
            Id = "2200A";
            Name = "Transmission Receipt Control Identifier";
            
            Segment(x => x.TransmissionReceiptControlIdentifier, 0, x => x.IsRequired());
            Segment(x => x.InformationSourceReceiptDate, 1,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("050")));
            Segment(x => x.InformationSourceProcessDate, 2,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.DateTimeQualifier.IsEqualTo("009")));
        }
    }
}