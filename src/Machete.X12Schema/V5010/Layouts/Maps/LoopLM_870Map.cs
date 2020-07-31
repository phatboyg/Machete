namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_870Map :
        X12LayoutMap<LoopLM_870, X12Entity>
    {
        public LoopLM_870Map()
        {
            Id = "Loop_LM_870";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}