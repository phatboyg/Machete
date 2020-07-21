namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000A_277ACKMap :
        X12LayoutMap<Loop2000A_277ACK, X12Entity>
    {
        public Loop2000A_277ACKMap()
        {
            Id = "Loop_2000A_277_ACK";
            Name = "Information Source Detail";
            
            Segment(x => x.InformationSourceLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("20")));
            Layout(x => x.Loop2100A, 1);
            Layout(x => x.Loop2200A, 2);
        }
    }
}