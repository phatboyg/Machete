namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000B_837IMap :
        X12LayoutMap<Loop2000B_837I, X12Entity>
    {
        public Loop2000B_837IMap()
        {
            Id = "Loop_2000B_837I";
            Name = "Subscriber Hierarchical Level";
            
            Segment(x => x.HierarchicalLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("22")));
            Segment(x => x.SubscriberInformation, 1);
            Layout(x => x.Loop2010BA, 3);
            Layout(x => x.Loop2010BB, 4);
        }
    }
}