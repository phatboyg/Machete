namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T828Map :
        X12LayoutMap<T828, X12Entity>
    {
        public T828Map()
        {
            Id = "T828";
            Name = "828 Debit Authorization";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningDebitAuthorization, 2);
            Segment(x => x.Name, 3);
            Segment(x => x.AdditionalNameInformation, 4);
            Segment(x => x.AddressInformation, 5);
            Segment(x => x.GeographicInformation, 6);
            Segment(x => x.ReferenceInformation, 7);
            Segment(x => x.AdministrativeCommunicationsContact, 8);
            Layout(x => x.LoopDAD, 9);
            Segment(x => x.TransactionTotals, 10);
            Segment(x => x.MonetaryAmount, 11);
            Segment(x => x.TransactionSetTrailer, 12);
            Segment(x => x.FunctionalGroupTrailer, 13);
        }
    }
}