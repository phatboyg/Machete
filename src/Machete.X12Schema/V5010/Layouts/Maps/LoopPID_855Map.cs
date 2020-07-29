namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPID_855Map :
        X12LayoutMap<LoopPID_855, X12Entity>
    {
        public LoopPID_855Map()
        {
            Id = "Loop_PID_855";
            Name = "Loop PID";
            
            Segment(x => x.ProductOrITemDescription, 0);
            Segment(x => x.Measurements, 1);
        }
    }
}