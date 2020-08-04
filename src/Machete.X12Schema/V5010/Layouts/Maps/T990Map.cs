namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T990Map :
        X12LayoutMap<T990, X12Entity>
    {
        public T990Map()
        {
            Id = "T990";
            Name = "990 Response to a Load Tender";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningBookingOrPickupDelivery, 2);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 3);
            Segment(x => x.TransactionSetTrailer, 4);
            Segment(x => x.FunctionalGroupTrailer, 5);
        }
    }
}