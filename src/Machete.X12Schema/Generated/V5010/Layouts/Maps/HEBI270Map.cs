namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class HEBI270Map :
        X12LayoutMap<HEBI270, X12Entity>
    {
        public HEBI270Map()
        {
            Id = "270";
            Name = "Healthcare Eligibility Benefit Inquiry";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Segment(x => x.FunctionalGroupHeader, 1);
            Segment(x => x.TransactionSetHeader, 20, x => x.IsRequired());
            Segment(x => x.BeginningOfHeirarchicalTransaction, 3, x => x.IsRequired());
            Layout(x => x.InformationSourceDetail, 4);
            Layout(x => x.InformationReceiverDetail, 5);
            Layout(x => x.SubscriberDetail, 6);
            Layout(x => x.DependentDetail, 7);
            Segment(x => x.TransactionSetTrailer, 8, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 9);
            Segment(x => x.InterchangeControlTrailer, 10);
        }
    }
}