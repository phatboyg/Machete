namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLDT_3_865Map :
        X12LayoutMap<LoopLDT_3_865, X12Entity>
    {
        public LoopLDT_3_865Map()
        {
            Id = "Loop_LDT_3_865";
            Name = "Loop LDT";
            
            Segment(x => x.LeadTime, 0);
            Segment(x => x.MarksAndNumbersInformation, 1);
            Segment(x => x.Quantity, 2);
            Segment(x => x.Text, 3);
        }
    }
}