namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopAMT_850Map :
        X12LayoutMap<LoopAMT_850, X12Entity>
    {
        public LoopAMT_850Map()
        {
            Id = "Loop_AMT_850";
            Name = "Loop AMT";
            
            Segment(x => x.MonetaryAmount, 0);
            Segment(x => x.ReferenceIdentification, 1);
            Segment(x => x.DateOrTimeReference, 2);
            Segment(x => x.PercentAmounts, 3);
            Layout(x => x.LoopFA1, 4);
        }
    }
}