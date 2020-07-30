namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_869Map :
        X12LayoutMap<LoopLM_869, X12Entity>
    {
        public LoopLM_869Map()
        {
            Id = "Loop_LM_869";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}