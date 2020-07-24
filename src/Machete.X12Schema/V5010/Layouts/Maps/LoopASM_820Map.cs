namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopASM_820Map :
        X12LayoutMap<LoopASM_820, X12Entity>
    {
        public LoopASM_820Map()
        {
            Id = "Loop_ASM_820";
            Name = "Loop ASM";
            
            Segment(x => x.MonetaryAmount, 0);
            Segment(x => x.Adjustment, 1);
        }
    }
}