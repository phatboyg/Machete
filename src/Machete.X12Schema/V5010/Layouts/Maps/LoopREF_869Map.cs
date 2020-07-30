namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopREF_869Map :
        X12LayoutMap<LoopREF_869, X12Entity>
    {
        public LoopREF_869Map()
        {
            Id = "Loop_REF_869";
            Name = "Loop REF";
            
            Segment(x => x.ReferenceIdentification, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}