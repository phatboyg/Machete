namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T869Map :
        X12LayoutMap<T869, X12Entity>
    {
        public T869Map()
        {
            Id = "T869";
            Name = "855 Order Status Inquiry";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningOrderStatusInquiry, 2);
            Segment(x => x.NoteOrSpecialInstructions, 3);
            Layout(x => x.LoopHL, 4);
            Segment(x => x.TransactionTotals, 5);
            Segment(x => x.TransactionSetTrailer, 6);
            Segment(x => x.FunctionalGroupTrailer, 7);
        }
    }
}