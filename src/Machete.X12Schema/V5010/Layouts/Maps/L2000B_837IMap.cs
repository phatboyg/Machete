namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000B_837IMap :
        X12LayoutMap<L2000B_837I, X12Entity>
    {
        public L2000B_837IMap()
        {
            Id = "2000B";
            Name = "Subscriber Hierarchical Level";
            
            Segment(x => x.SubscriberHierarchicalLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("22")));
            Segment(x => x.SubscriberInformation, 1);
            Layout(x => x.Subscriber, 3);
            Layout(x => x.Payer, 4);
        }
    }
}