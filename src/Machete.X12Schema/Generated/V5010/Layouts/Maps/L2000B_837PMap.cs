namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000B_837PMap :
        X12LayoutMap<L2000B_837P, X12Entity>
    {
        public L2000B_837PMap()
        {
            Id = "2000B";
            Name = "Subscriber Hierarchical Level";
            
            Segment(x => x.SubscriberHierarchicalLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("22")));
            Segment(x => x.SubscriberInformation, 1);
            Segment(x => x.PatientInformation, 2);
            Layout(x => x.Subscriber, 3);
            Layout(x => x.Payer, 4);
        }
    }
}