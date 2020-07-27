namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLDT_1_850Map :
        X12LayoutMap<LoopLDT_1_850, X12Entity>
    {
        public LoopLDT_1_850Map()
        {
            Id = "Loop_LDT_1_850";
            Name = "Loop LDT";
            
            Segment(x => x.LeadTime, 0);
            Segment(x => x.QuantityInformation, 1);
            Segment(x => x.Text, 2);
            Segment(x => x.ReferenceInformation, 3);
        }
    }
}