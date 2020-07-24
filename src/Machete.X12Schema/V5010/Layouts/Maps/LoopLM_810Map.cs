namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_810Map :
        X12LayoutMap<LoopLM_810, X12Entity>
    {
        public LoopLM_810Map()
        {
            Id = "Loop_LM_810";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}