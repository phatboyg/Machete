namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopAMT_1_860Map :
        X12LayoutMap<LoopAMT_1_860, X12Entity>
    {
        public LoopAMT_1_860Map()
        {
            Id = "Loop_AMT_860";
            Name = "Loop AMT";
            
            Segment(x => x.MonetaryAmountInformation, 0);
            Segment(x => x.ReferenceInformation, 1);
            Segment(x => x.DateOrTimeReference, 2);
            Segment(x => x.PercentAmounts, 3);
            Layout(x => x.LoopFA1, 4);
        }
    }
}