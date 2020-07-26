namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLDT_850Map :
        X12LayoutMap<LoopLDT_850, X12Entity>
    {
        public LoopLDT_850Map()
        {
            Id = "Loop_LDT_850";
            Name = "Loop LDT";
            
            Segment(x => x.LeadTime, 0);
            Segment(x => x.MarksAndNumbers, 1);
            Segment(x => x.Quantity, 2);
            Segment(x => x.MessageText, 3);
            Segment(x => x.ReferenceIdentification, 4);
        }
    }
}