namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLMMap :
        X12LayoutMap<LoopLM, X12Entity>
    {
        public LoopLMMap()
        {
            Id = "Loop_LM";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}