namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HCSR276Map :
        X12LayoutMap<HCSR276, X12Entity>
    {
        public HCSR276Map()
        {
            Id = "276";
            Name = "Healthcare Claim Status Request";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Segment(x => x.FunctionalGroupHeader, 1);
            Segment(x => x.TransactionSetHeader, 2, x => x.IsRequired());
            Segment(x => x.BeginningOfHeirarchicalTransaction, 3, x => x.IsRequired());
            Layout(x => x.InformationSourceDetail, 4);
            Layout(x => x.InformationReceiverDetail, 5);
            Layout(x => x.ServiceProviderDetail, 6);
            Layout(x => x.SubscriberDetail, 7);
            Layout(x => x.DependentDetail, 8);
            Segment(x => x.TransactionSetTrailer, 9, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 10);
            Segment(x => x.InterchangeControlTrailer, 11);
        }
    }
}