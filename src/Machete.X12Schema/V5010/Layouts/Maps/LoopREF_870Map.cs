namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopREF_870Map :
        X12LayoutMap<LoopREF_870, X12Entity>
    {
        public LoopREF_870Map()
        {
            Id = "Loop_REF_870";
            Name = "Loop REF";
            
            Segment(x => x.ReferenceIdentification, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}