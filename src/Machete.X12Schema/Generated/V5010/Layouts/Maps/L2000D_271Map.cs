namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000D_271Map :
        X12LayoutMap<L2000D_271, X12Entity>
    {
        public L2000D_271Map()
        {
            Id = "2100C";
            Name = "Subscriber Name";
            
            Segment(x => x.DependentLevel, 0);
            Segment(x => x.DependentTraceNumber, 1);
            Layout(x => x.Dependent, 2);
        }
    }
}