namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000B_277ACKMap :
        X12LayoutMap<Loop2000B_277ACK, X12Entity>
    {
        public Loop2000B_277ACKMap()
        {
            Id = "Loop_2000B_277_ACK";
            Name = "Information Receiver Detail";
            
            Segment(x => x.InformationSourceLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("21")));
            Layout(x => x.Loop2100B, 1);
            Layout(x => x.Loop2200B, 2);
        }
    }
}