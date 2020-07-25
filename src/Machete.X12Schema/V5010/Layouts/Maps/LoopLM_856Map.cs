namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_856Map :
        X12LayoutMap<LoopLM_856, X12Entity>
    {
        public LoopLM_856Map()
        {
            Id = "Loop_LM_856";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCode, 1);
        }
    }
}