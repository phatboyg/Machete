namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN9_2_860Map :
        X12LayoutMap<LoopN9_2_860, X12Entity>
    {
        public LoopN9_2_860Map()
        {
            Id = "Loop_N9_2_860";
            Name = "Loop N9";
            
            Segment(x => x.ExtendedReferenceInformation, 0);
            Segment(x => x.DateOrTimeReference, 1);
            Segment(x => x.Text, 2);
        }
    }
}