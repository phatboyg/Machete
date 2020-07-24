namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_812Map :
        X12LayoutMap<LoopLM_812, X12Entity>
    {
        public LoopLM_812Map()
        {
            Id = "Loop_LM_812";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}