namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class T277Map :
        X12LayoutMap<CAT277, X12Entity>
    {
        public T277Map()
        {
            Id = "277";
            Name = "Healthcare Claim Acknowledgement";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1, x => x.IsRequired());
            Segment(x => x.BeginningOfHeirarchicalTransaction, 2, x => x.IsRequired());
            Layout(x => x.InformationSourceDetail, 3);
            Layout(x => x.InformationReceiverDetail, 4);
            Layout(x => x.BillingProviderOfServiceDetail, 5);
            Layout(x => x.InformationReceiverDetail, 6);
            Layout(x => x.PatientDetail, 7);
            Segment(x => x.TransactionSetTrailer, 8);
            Segment(x => x.FunctionalGroupTrailer, 9);
        }
    }
}