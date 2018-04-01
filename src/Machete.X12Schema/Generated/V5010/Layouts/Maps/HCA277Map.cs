namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HCA277Map :
        X12LayoutMap<HCA277, X12Entity>
    {
        public HCA277Map()
        {
            Id = "277";
            Name = "Healthcare Claim Acknowledgement";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Segment(x => x.FunctionalGroupHeader, 1);
            Segment(x => x.TransactionSetHeader, 2, x => x.IsRequired());
            Segment(x => x.BeginningOfHeirarchicalTransaction, 3, x => x.IsRequired());
            Layout(x => x.InformationSourceDetail, 4);
            Layout(x => x.InformationReceiverDetail, 5);
            Layout(x => x.BillingProviderOfServiceDetail, 6);
            Layout(x => x.InformationReceiverDetail, 7);
            Layout(x => x.PatientDetail, 8);
            Segment(x => x.TransactionSetTrailer, 9);
            Segment(x => x.FunctionalGroupTrailer, 10);
            Segment(x => x.InterchangeControlTrailer, 11);
        }
    }
}