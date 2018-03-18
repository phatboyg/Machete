namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class L2110_ACK999Map :
        X12LayoutMap<L2110_ACK999, X12Entity>
    {
        public L2110_ACK999Map()
        {
            Id = "2110";
            Name = "Implementation Data Element Note";
            
            Segment(x => x.ImplementationDataElementNote, 0);
            Segment(x => x.ElementContext, 1);
        }
    }
}