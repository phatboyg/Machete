namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T862Map :
        X12LayoutMap<T862, X12Entity>
    {
        public T862Map()
        {
            Id = "T862";
            Name = "862 Shipping Schedule";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningShippingScheduleOrProductionSequence, 2);
            Segment(x => x.DateOrTimeReference, 3);
            Layout(x => x.LoopN1, 4);
            Layout(x => x.LoopLIN, 5);
            Segment(x => x.TransactionTotals, 6);
            Segment(x => x.TransactionSetTrailer, 7);
            Segment(x => x.FunctionalGroupTrailer, 8);
        }
    }
}