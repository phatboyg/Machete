namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class HCPA835Map :
        X12LayoutMap<HCPA835, X12Entity>
    {
        public HCPA835Map()
        {
            Id = "835";
            Name = "Healthcare Claim Payment/Advice";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Segment(x => x.FunctionalGroupHeader, 1);
            Segment(x => x.TransactionSetHeader, 2, x => x.IsRequired());
            Segment(x => x.FinancialInformation, 3, x => x.IsRequired());
            Segment(x => x.ReassociationTraceNumber, 4, x => x.IsRequired());
            Segment(x => x.ForeignCurrencyInformation, 5);
            Segment(x => x.ReceiverIdentification, 6);
            Segment(x => x.VersionIdentification, 7);
            Segment(x => x.ProductionDate, 8);
            Layout(x => x.PayerIdentification, 9);
            Layout(x => x.PayeeIdentification, 10);
            Layout(x => x.HeaderNumber, 11);
            Segment(x => x.ProviderAdjustment, 12);
            Segment(x => x.TransactionSetTrailer, 13, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 14);
            Segment(x => x.InterchangeControlTrailer, 15);
        }
    }
}