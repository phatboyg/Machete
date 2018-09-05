namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000B_277ACKMap :
        X12LayoutMap<L2000B_277ACK, X12Entity>
    {
        public L2000B_277ACKMap()
        {
            Id = "2000B";
            Name = "Information Receiver Detail";
            
            Segment(x => x.InformationSourceLevel, 0,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("21")));
            Layout(x => x.InformationSourceName, 1);
            Layout(x => x.InformationReceiverApplicationTraceIdentifier, 2);
        }
    }
}