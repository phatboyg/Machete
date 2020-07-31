namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T870Map :
        X12LayoutMap<T870, X12Entity>
    {
        public T870Map()
        {
            Id = "T870";
            Name = "870 Order Status Report";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningOrderStatusReport, 2);
            Segment(x => x.CarrierDetailsEquipment, 3);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 4);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 5);
            Segment(x => x.DateOrTimeReference, 6);
            Layout(x => x.LoopREF, 7);
            Layout(x => x.LoopN1, 8);
            Layout(x => x.LoopLM, 9);
            Layout(x => x.LoopHL, 10);
            Segment(x => x.TransactionTotals, 11);
            Segment(x => x.TransactionSetTrailer, 12);
            Segment(x => x.FunctionalGroupTrailer, 13);
        }
    }
}