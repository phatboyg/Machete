namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopREF_846Map :
        X12LayoutMap<LoopREF_846, X12Entity>
    {
        public LoopREF_846Map()
        {
            Id = "Loop_REF_846";
            Name = "Loop REF";
            
            Segment(x => x.ReferenceInformation, 0);
            Segment(x => x.DateOrTimeReference, 1);
            Segment(x => x.PartyInformation, 2);
            Layout(x => x.LoopLM, 3);
        }
    }
}