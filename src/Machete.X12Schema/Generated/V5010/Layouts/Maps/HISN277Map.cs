namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HISN277Map :
        X12LayoutMap<HISN277, X12Entity>
    {
        public HISN277Map()
        {
            Id = "277";
            Name = "Healthcare Claim Request for Additional Information";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Segment(x => x.FunctionalGroupHeader, 1);
            Segment(x => x.TransactionSetHeader, 2, x => x.IsRequired());
            Segment(x => x.BeginningOfHeirarchicalTransaction, 3, x => x.IsRequired());
            Layout(x => x.InformationSourceDetail, 4);
            Layout(x => x.InformationReceiverDetail, 5);
            Layout(x => x.ServiceProviderDetail, 6);
            Layout(x => x.PatientDetail, 7);
            Segment(x => x.TransactionSetTrailer, 8, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 9);
            Segment(x => x.InterchangeControlTrailer, 10);
        }
    }
}