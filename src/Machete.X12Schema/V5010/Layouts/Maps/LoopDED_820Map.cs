namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopDED_820Map :
        X12LayoutMap<LoopDED_820, X12Entity>
    {
        public LoopDED_820Map()
        {
            Id = "Loop_DED_820";
            Name = "Loop DED";
            
            Segment(x => x.Deductions, 0);
        }
    }
}