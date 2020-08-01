namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLM_865Map :
        X12LayoutMap<LoopLM_865, X12Entity>
    {
        public LoopLM_865Map()
        {
            Id = "Loop_LM_865";
            Name = "Loop LM";
            
            Segment(x => x.CodeSourceInformation, 0);
            Segment(x => x.IndustryCodeIdentification, 1);
        }
    }
}