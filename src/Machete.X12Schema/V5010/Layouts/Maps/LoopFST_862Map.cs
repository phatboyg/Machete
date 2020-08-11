namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopFST_862Map :
        X12LayoutMap<LoopFST_862, X12Entity>
    {
        public LoopFST_862Map()
        {
            Id = "Loop_FST_862";
            Name = "Loop FST";  
            
            Segment(x => x.ForecastSchedule, 0);
            Segment(x => x.DateOrTimeReference, 1);
            Layout(x => x.LoopSHP, 2);
        }
    }
}