namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_850Map :
        X12LayoutMap<LoopLM_850, X12Entity>
    {
        public LoopLM_850Map()
        {
            Id = "Loop_LM_850";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}