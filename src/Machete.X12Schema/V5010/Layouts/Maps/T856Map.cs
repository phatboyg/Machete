namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T856Map :
        X12LayoutMap<T856, X12Entity>
    {
        public T856Map()
        {
            Id = "T856";
            Name = "Ship Notice/Manifest";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningShipNotice, 2);
            Segment(x => x.DateOrTimeReference, 3);
            Layout(x => x.LoopHL, 4);
            Segment(x => x.TransactionTotals, 5);
            Segment(x => x.TransactionSetTrailer, 6);
            Segment(x => x.FunctionalGroupTrailer, 7);
        }
    }
}