namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopAMT_820Map :
        X12LayoutMap<LoopAMT_820, X12Entity>
    {
        public LoopAMT_820Map()
        {
            Id = "Loop_AMT_820";
            Name = "Loop AMT";
            
            Segment(x => x.MonetaryAmount, 0);
            Segment(x => x.ReferenceIdentification, 1);
        }
    }
}