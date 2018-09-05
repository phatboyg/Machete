namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class T837PMap :
        X12LayoutMap<T837P, X12Entity>
    {
        public T837PMap()
        {
            Id = "837P";
            Name = "837P Transaction";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1, x => x.IsRequired());
            Segment(x => x.BeginningOfHierarchicalTransaction, 2, x => x.IsRequired());
            Layout(x => x.Submitter, 3);
            Layout(x => x.Receiver, 4);
            Layout(x => x.BillingProviderDetail, 5);
            Layout(x => x.Receiver, 6);
            Layout(x => x.PayToAddressName, 7);
            Layout(x => x.PayToPlanName, 8);
            Layout(x => x.SubscriberDetail, 9);
            Layout(x => x.PatientDetail, 10);
            Segment(x => x.TransactionSetTrailer, 11);
            Segment(x => x.FunctionalGroupTrailer, 12);
        }
    }
}