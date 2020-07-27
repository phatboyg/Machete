namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLDT_3_860Map :
        X12LayoutMap<LoopLDT_3_860, X12Entity>
    {
        public LoopLDT_3_860Map()
        {
            Id = "Loop_LDT_3_860";
            Name = "Loop LDT";
            
            Segment(x => x.LeadTime, 0);
            Segment(x => x.MarksAndNumbersInformation, 1);
            Segment(x => x.QuantityInformation, 2);
            Segment(x => x.Text, 3);
            Segment(x => x.ReferenceInformation, 4);
        }
    }
}