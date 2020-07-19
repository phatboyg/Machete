namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000D_270Map :
        X12LayoutMap<L2000D_270, X12Entity>
    {
        public L2000D_270Map()
        {
            Id = "2000D";
            Name = "Dependent Level";
            
            Segment(x => x.DependentLevel, 0);
            Segment(x => x.DependentTraceNumber, 1);
            Layout(x => x.Dependent, 2);
        }
    }
}