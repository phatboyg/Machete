namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopREF_820Map :
        X12LayoutMap<LoopREF_1_820, X12Entity>
    {
        public LoopREF_820Map()
        {
            Id = "Loop_REF_820";
            Name = "Loop REF";
            
            Segment(x => x.ReferenceIdentification, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}