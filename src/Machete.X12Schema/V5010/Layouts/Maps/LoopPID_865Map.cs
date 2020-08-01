namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPID_865Map :
        X12LayoutMap<LoopPID_865, X12Entity>
    {
        public LoopPID_865Map()
        {
            Id = "Loop_PID_865";
            Name = "Loop PID";
            
            Segment(x => x.ProductOrITemDescription, 0);
            Segment(x => x.Measurements, 1);
        }
    }
}