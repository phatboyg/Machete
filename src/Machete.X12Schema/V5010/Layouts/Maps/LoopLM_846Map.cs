namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_846Map :
        X12LayoutMap<LoopLM_846, X12Entity>
    {
        public LoopLM_846Map()
        {
            Id = "Loop_LM_846";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}