namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T829Map :
        X12LayoutMap<T829, X12Entity>
    {
        public T829Map()
        {
            Id = "F828";
            Name = "828 Debit Authorization";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.PaymentCancellationRequest, 2);
            Segment(x => x.Trace, 3);
            Segment(x => x.DateOrTimeReference, 4);
            Segment(x => x.ReferenceIdentification, 5);
            Segment(x => x.Quantity, 6);
            Segment(x => x.MonetaryAmount, 7);
            Segment(x => x.TransactionSetTrailer, 8);
            Segment(x => x.FunctionalGroupTrailer, 9);
        }
    }
}