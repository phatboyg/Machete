namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000D_270Map :
        X12LayoutMap<Loop2000D_270, X12Entity>
    {
        public Loop2000D_270Map()
        {
            Id = "Loop_2000D_270";
            Name = "Dependent Level";
            
            Segment(x => x.DependentLevel, 0);
            Segment(x => x.DependentTraceNumber, 1);
            Layout(x => x.Loop2100D, 2);
        }
    }
}