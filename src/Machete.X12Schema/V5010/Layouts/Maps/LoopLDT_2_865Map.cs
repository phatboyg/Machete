namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLDT_2_865Map :
        X12LayoutMap<LoopLDT_2_865, X12Entity>
    {
        public LoopLDT_2_865Map()
        {
            Id = "Loop_LDT_2_865";
            Name = "Loop LDT";
            
            Segment(x => x.LeadTime, 0);
            Segment(x => x.QuantityInformation, 1);
            Segment(x => x.Text, 2);
            Layout(x => x.LoopLM, 3);
        }
    }
}