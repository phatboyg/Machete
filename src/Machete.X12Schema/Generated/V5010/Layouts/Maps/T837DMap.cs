namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class T837DMap :
        X12LayoutMap<T837D, X12Entity>
    {
        public T837DMap()
        {
            Id = "837I";
            Name = "837D Transaction";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1, x => x.IsRequired());
            Segment(x => x.BeginningOfHierarchicalTransaction, 2, x => x.IsRequired());
            Layout(x => x.Submitter, 3);
            Layout(x => x.Receiver, 4);
            Layout(x => x.BillingProviderDetail, 5);
            Layout(x => x.Receiver, 6);
            Layout(x => x.SubscriberDetail, 7);
            Layout(x => x.PatientDetail, 8);
            Segment(x => x.TransactionSetTrailer, 9);
            Segment(x => x.FunctionalGroupTrailer, 10);
        }
    }
}