namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000A_277Map :
        X12LayoutMap<Loop2000A_277, X12Entity>
    {
        public Loop2000A_277Map()
        {
            Id = "Loop_2000A_277";
            Name = "Information Source Name";
            
            Segment(x => x.InformationSourceLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("20")));
            Layout(x => x.Loop2100A, 1);
        }
    }
}