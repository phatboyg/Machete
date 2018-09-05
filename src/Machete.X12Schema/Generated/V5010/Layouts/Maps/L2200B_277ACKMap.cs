namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2200B_277ACKMap :
        X12LayoutMap<L2200B_277ACK, X12Entity>
    {
        public L2200B_277ACKMap()
        {
            Id = "2200B";
            Name = "Information Receiver Application Trace Identifier";
            
            Segment(x => x.ApplicationTraceIdentifier, 0, x => x.IsRequired());
            Segment(x => x.StatusInformation, 1, x => x.IsRequired());
            Segment(x => x.TotalAcceptedQuantity, 2, x => x.Condition = parser => parser.Where(p => p.QuantityQualifier.IsEqualTo("90")));
            Segment(x => x.TotalRejectedQuantity, 3, x => x.Condition = parser => parser.Where(p => p.QuantityQualifier.IsEqualTo("AA")));
            Segment(x => x.TotalAcceptedAmount, 4, x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("YU")));
            Segment(x => x.TotalRejectedAmount, 5, x => x.Condition = parser => parser.Where(p => p.AmountQualifierCode.IsEqualTo("YY")));
        }
    }
}