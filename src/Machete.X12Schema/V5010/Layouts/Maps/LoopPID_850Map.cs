namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPID_850Map :
        X12LayoutMap<LoopPID_850, X12Entity>
    {
        public LoopPID_850Map()
        {
            Id = "Loop_PID_850";
            Name = "Loop PID";
            
            Segment(x => x.ProductOrITemDescription, 0);
            Segment(x => x.Measurements, 1);
        }
    }
}