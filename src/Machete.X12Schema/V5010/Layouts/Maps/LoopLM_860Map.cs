namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_860Map :
        X12LayoutMap<LoopLM_860, X12Entity>
    {
        public LoopLM_860Map()
        {
            Id = "Loop_LM_860";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}