namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000C_277Map :
        X12LayoutMap<L2000C_277, X12Entity>
    {
        public L2000C_277Map()
        {
            Id = "2000C";
            Name = "Service Provider Detail";
            
            Segment(x => x.ServiceProviderLevel, 0,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("19")));
            Layout(x => x.ServiceProviderName, 1);
        }
    }
}