namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000C_277Map :
        X12LayoutMap<Loop2000C_277, X12Entity>
    {
        public Loop2000C_277Map()
        {
            Id = "Loop_2000C_277";
            Name = "Service Provider Detail";
            
            Segment(x => x.ServiceProviderLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("19")));
            Layout(x => x.Loop2100C, 1);
        }
    }
}