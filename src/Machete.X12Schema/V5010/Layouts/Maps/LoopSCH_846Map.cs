namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSCH_846Map :
        X12LayoutMap<LoopSCH_846, X12Entity>
    {
        public LoopSCH_846Map()
        {
            Id = "Loop_SCH_846";
            Name = "Loop SCH";
            
            Segment(x => x.LineItemSchedule, 0);

            Segment(x => x.Measurements, 1);
        }
    }
}