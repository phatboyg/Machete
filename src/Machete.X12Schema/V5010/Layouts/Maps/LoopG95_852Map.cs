namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopG95_852Map :
        X12LayoutMap<LoopG95_852, X12Entity>
    {
        public LoopG95_852Map()
        {
            Id = "Loop_G95_852";
            Name = "Loop G95";  
            
            Segment(x => x.PerformanceRequirements, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}