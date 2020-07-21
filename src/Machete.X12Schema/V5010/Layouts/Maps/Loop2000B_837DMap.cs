namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000B_837DMap :
        X12LayoutMap<Loop2000B_837D, X12Entity>
    {
        public Loop2000B_837DMap()
        {
            Id = "Loop_2000B_837D";
            Name = "Subscriber Hierarchical Level";
            
            Segment(x => x.HierarchicalLevel, 0);
            Segment(x => x.SubscriberInformation, 1);
            Layout(x => x.Loop2010BA, 3);
            Layout(x => x.Loop2010BB, 4);
        }
    }
}