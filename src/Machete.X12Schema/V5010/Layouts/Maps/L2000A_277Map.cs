namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000A_277Map :
        X12LayoutMap<L2000A_277, X12Entity>
    {
        public L2000A_277Map()
        {
            Id = "2000A";
            Name = "Information Source Name";
            
            Segment(x => x.InformationSourceLevel, 0,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("20")));
            Layout(x => x.PayerName, 1);
        }
    }
}