namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPID_860Map :
        X12LayoutMap<LoopPID_860, X12Entity>
    {
        public LoopPID_860Map()
        {
            Id = "Loop_PID_860";
            Name = "Loop PID";
            
            Segment(x => x.ProductOrITemDescription, 0);
            Segment(x => x.Measurements, 1);
        }
    }
}