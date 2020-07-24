namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPID_820Map :
        X12LayoutMap<LoopPID_820, X12Entity>
    {
        public LoopPID_820Map()
        {
            Id = "Loop_PID_820";
            Name = "Loop PID";
            
            Segment(x => x.ProductOrITemDescription, 0);
            Segment(x => x.DateOrTimeReference, 1);
            Layout(x => x.LoopPCT, 2);
        }
    }
}