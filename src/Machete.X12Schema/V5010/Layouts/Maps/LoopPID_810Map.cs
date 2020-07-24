namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPID_810Map :
        X12LayoutMap<LoopPID_810, X12Entity>
    {
        public LoopPID_810Map()
        {
            Id = "Loop_PID_810";
            Name = "Loop PID";
            
            Segment(x => x.ProductOrItemDescription, 0);
            Segment(x => x.Measurements, 1);
        }
    }
}