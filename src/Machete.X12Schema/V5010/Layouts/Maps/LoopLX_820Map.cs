namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_820Map :
        X12LayoutMap<LoopLX_820, X12Entity>
    {
        public LoopLX_820Map()
        {
            Id = "Loop_LX_820";
            Name = "Loop LX";
            
            Segment(x => x.AssignedNumber, 0);
            Segment(x => x.ReferenceIdentification, 1);
            Segment(x => x.Trace, 2);
            Layout(x => x.LoopREF, 3);
        }
    }
}