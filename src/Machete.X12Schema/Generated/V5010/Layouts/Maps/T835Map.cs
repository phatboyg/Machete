namespace Machete.X12Schema.V5010
{
    using X12;
    using X12.Configuration;


    public class T835Map :
        X12LayoutMap<T835, X12Entity>
    {
        public T835Map()
        {
            Id = "TG835";
            Name = "835 Transaction";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1, x => x.IsRequired());
            Segment(x => x.FinancialInformation, 2, x => x.IsRequired());
            Segment(x => x.ReassociationTraceNumber, 3, x => x.IsRequired());
            Segment(x => x.ForeignCurrencyInformation, 4);
            Segment(x => x.ReceiverIdentification, 5,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("EV")));
            Segment(x => x.VersionIdentification, 6,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("F2")));
            Segment(x => x.ProductionDate, 7);
            Layout(x => x.PayerIdentification, 8);
            Layout(x => x.PayeeIdentification, 9);
            Layout(x => x.HeaderNumber, 10);
            Segment(x => x.ProviderAdjustment, 11);
            Segment(x => x.TransactionSetTrailer, 12, x => x.IsRequired());
            Segment(x => x.FunctionalGroupTrailer, 13);
        }
    }
}