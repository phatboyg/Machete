namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPEN_820Map :
        X12LayoutMap<LoopPEN_820, X12Entity>
    {
        public LoopPEN_820Map()
        {
            Id = "Loop_PEN_820";
            Name = "Loop PEN";
            
            Segment(x => x.PensionInformation, 0);
            Segment(x => x.MonetaryAmount, 1);
            Segment(x => x.DateOrTimeReference, 2);
            Layout(x => x.LoopINV, 3);
        }
    }
}