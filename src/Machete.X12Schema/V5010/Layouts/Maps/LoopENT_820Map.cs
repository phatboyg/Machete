namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopENT_820Map :
        X12LayoutMap<LoopENT_820, X12Entity>
    {
        public LoopENT_820Map()
        {
            Id = "Loop_ENT_820";
            Name = "Loop ENT";
            
            Segment(x => x.Entity, 0);
            Layout(x => x.LoopNM1, 1);
            Layout(x => x.LoopADX, 2);
            Layout(x => x.LoopRMR, 3);
        }
    }
}