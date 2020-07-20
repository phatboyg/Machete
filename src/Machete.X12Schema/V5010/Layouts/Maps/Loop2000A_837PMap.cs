namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000A_837PMap :
        X12LayoutMap<Loop2000A_837P, X12Entity>
    {
        public Loop2000A_837PMap()
        {
            Id = "2000A";
            Name = "Subscriber Hierarchical Level";
            
            Segment(x => x.HierarchicalLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("20")));
            Segment(x => x.SpecialtyInformation, 1);
            Segment(x => x.ForeignCurrencyInformation, 2);
            Layout(x => x.Loop2010AA, 3);
            Layout(x => x.Loop2010AB, 4);
            Layout(x => x.Loop2010AC, 5);
        }
    }
}