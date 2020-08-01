namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN9_820Map :
        X12LayoutMap<LoopN9_820, X12Entity>
    {
        public LoopN9_820Map()
        {
            Id = "Loop_N9_820";
            Name = "Loop N9";
            
            Segment(x => x.ExtendedReferenceInformation, 0);
            Layout(x => x.LoopAMT, 1);
            Layout(x => x.LoopN1, 2);
        }
    }
}