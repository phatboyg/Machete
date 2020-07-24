namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLOC_820Map :
        X12LayoutMap<LoopLOC_820, X12Entity>
    {
        public LoopLOC_820Map()
        {
            Id = "Loop_LOC_820";
            Name = "Loop LOC";
            
            Segment(x => x.Location, 0);
            Layout(x => x.LoopPID, 1);
        }
    }
}