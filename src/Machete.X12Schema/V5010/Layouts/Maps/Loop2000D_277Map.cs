namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000D_277Map :
        X12LayoutMap<Loop2000D_277, X12Entity>
    {
        public Loop2000D_277Map()
        {
            Id = "Loop_2000D_277";
            Name = "Patient Level";
            
            Segment(x => x.ServiceProviderLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("PT")));
            Layout(x => x.Loop2100D, 1);
            Layout(x => x.Loop2200D, 2);
         }
    }
}