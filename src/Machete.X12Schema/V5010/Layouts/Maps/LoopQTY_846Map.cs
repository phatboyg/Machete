namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopQTY_846Map :
        X12LayoutMap<LoopQTY_846, X12Entity>
    {
        public LoopQTY_846Map()
        {
            Id = "Loop_QTY_846";
            Name = "Loop QTY";
            
            Segment(x => x.QuantityInformation, 0);
            Segment(x => x.UnitDetail, 1);
            Segment(x => x.Measurements, 2);
            Segment(x => x.LeadTime, 3);
            Segment(x => x.DateOrTimeReference, 4);
            Layout(x => x.LoopSCH, 5);
            Layout(x => x.LoopLM, 6);
            Segment(x => x.LoopHeader, 7);
            Layout(x => x.LoopREF, 8);
            Segment(x => x.LoopTrailer, 9);
        }
    }
}