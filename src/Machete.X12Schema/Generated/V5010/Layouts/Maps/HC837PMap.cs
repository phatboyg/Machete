namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HC837PMap :
        X12LayoutMap<HC837P, X12Entity>
    {
        public HC837PMap()
        {
            Id = "837P";
            Name = "Healthcare Claim";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Segment(x => x.FunctionalGroupHeader, 1);
            Segment(x => x.TransactionSetHeader, 2, x => x.IsRequired());
            Segment(x => x.BeginningOfHeirarchicalTransaction, 3, x => x.IsRequired());
            Layout(x => x.Submitter, 4);
            Layout(x => x.Receiver, 5);
            Layout(x => x.BillingProviderDetail, 6);
            Layout(x => x.Receiver, 7);
            Layout(x => x.SubscriberDetail, 8);
            Layout(x => x.PatientDetail, 9);
            Segment(x => x.TransactionSetTrailer, 10);
            Segment(x => x.FunctionalGroupTrailer, 11);
            Segment(x => x.InterchangeControlTrailer, 12);
        }
    }
}