namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPIDMap :
        X12LayoutMap<LoopPID, X12Entity>
    {
        public LoopPIDMap()
        {
            Id = "Loop_PID";
            Name = "Loop PID";
            
            Segment(x => x.ProductOrItemDescription, 0);
            Segment(x => x.Measurements, 1);
        }
    }
}