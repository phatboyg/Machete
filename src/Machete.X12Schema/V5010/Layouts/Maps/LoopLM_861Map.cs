namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_861Map :
        X12LayoutMap<LoopLM_861, X12Entity>
    {
        public LoopLM_861Map()
        {
            Id = "Loop_LM_861";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}