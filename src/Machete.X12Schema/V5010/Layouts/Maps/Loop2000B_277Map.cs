namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000B_277Map :
        X12LayoutMap<Loop2000B_277, X12Entity>
    {
        public Loop2000B_277Map()
        {
            Id = "Loop_2000B_277";
            Name = "Information Receiver Detail";
            
            Segment(x => x.InformationReceiverLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("21")));
            Layout(x => x.Loop2100B, 1);
        }
    }
}