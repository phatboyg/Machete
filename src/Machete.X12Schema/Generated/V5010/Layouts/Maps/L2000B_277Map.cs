namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000B_277Map :
        X12LayoutMap<L2000B_277, X12Entity>
    {
        public L2000B_277Map()
        {
            Id = "2000B";
            Name = "Information Receiver Detail";
            
            Segment(x => x.InformationReceiverLevel, 0,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("21")));
            Layout(x => x.InformationReceiverName, 1);
        }
    }
}