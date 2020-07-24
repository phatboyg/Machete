namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_2_820Map :
        X12LayoutMap<LoopN1_2_820, X12Entity>
    {
        public LoopN1_2_820Map()
        {
            Id = "Loop_N1_2_820";
            Name = "Loop N1";
            
            Segment(x => x.Name, 0);
            Segment(x => x.ReferenceIdentification, 1);
            Layout(x => x.LoopEMS, 2);
        }
    }
}