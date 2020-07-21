namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2110_ACK999Map :
        X12LayoutMap<Loop2110_ACK999, X12Entity>
    {
        public Loop2110_ACK999Map()
        {
            Id = "Loop_2110_999_ACK";
            Name = "Implementation Data Element Note";
            
            Segment(x => x.ImplementationDataElementNote, 0);
            Segment(x => x.ElementContext, 1);
        }
    }
}