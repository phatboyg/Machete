namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T810Map :
        X12LayoutMap<T810, X12Entity>
    {
        public T810Map()
        {
            Id = "T810";
            Name = "T810";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningSegmentForInvoice, 2);
            Segment(x => x.NotesOrSpecialInstructions, 3);
            Segment(x => x.Currency, 4);
            Segment(x => x.ReferenceInformation, 5);
            Segment(x => x.YesNoQuestion, 6);
            Segment(x => x.AdministrativeCommunicationsContact, 7);
            Layout(x => x.LoopN1, 8);
            Segment(x => x.TermsOfSale, 9);
            Segment(x => x.DateTimeReference, 10);
            Segment(x => x.FOBRelatedInstructions, 11);
            Segment(x => x.ProductOrItemDescription, 12);
            Segment(x => x.Measurements, 13);
            Segment(x => x.Paperwork, 14);
            Segment(x => x.MarkingPackagingOrLoadingRequirements, 15);
            Segment(x => x.TariffReference, 16);
            Segment(x => x.BalanceDetails, 17);
            Segment(x => x.InstallmentInformation, 18);
            Segment(x => x.PeriodAmount, 19);
            Segment(x => x.ConditionsIndicator, 20);
            Layout(x => x.LoopLM, 21);
            Layout(x => x.LoopN9, 22);
            Layout(x => x.LoopV1, 23);
            Layout(x => x.LoopFA1, 24);
            Layout(x => x.LoopIT1, 25);
            Segment(x => x.TotalMonetaryValueSummary, 26);
            Segment(x => x.TaxInformation, 27);
            Segment(x => x.CarrierDetails, 28);
            Segment(x => x.MonetaryAmountInformation, 29);
            Layout(x => x.LoopSAC, 30);
            Layout(x => x.LoopISS, 31);
            Segment(x => x.TransactionTotals, 32);
            Segment(x => x.TransactionSetTrailer, 33);
            Segment(x => x.FunctionalGroupTrailer, 34);
        }
    }
}