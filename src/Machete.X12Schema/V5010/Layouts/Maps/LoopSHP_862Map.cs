namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSHP_862Map :
        X12LayoutMap<LoopSHP_862, X12Entity>
    {
        public LoopSHP_862Map()
        {
            Id = "Loop_SHP_862";
            Name = "Loop SHP";  
            
            Segment(x => x.JustInTimeSchedule, 0);
            Segment(x => x.ReferenceInformation, 1);
            Segment(x => x.DateOrTimeReference, 2);
        }
    }
}