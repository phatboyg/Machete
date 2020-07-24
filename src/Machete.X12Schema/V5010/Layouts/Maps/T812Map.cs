namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T812Map :
        X12LayoutMap<T812, X12Entity>
    {
        public T812Map()
        {
            Id = "T812";
            Name = "812 Credit/Debit Adjustment";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningCreditOrDebitAdjustment, 2);
            Segment(x => x.Currency, 3);
            Segment(x => x.ReferenceIdentification, 4);
            Segment(x => x.AdministrativeCommunicationsContact, 5);
            Segment(x => x.TermsOfSale, 6);
            Segment(x => x.DateTimeReference, 7);
            Segment(x => x.FreeOnBoardRelatedInstructions, 8);
            Segment(x => x.ShipmentDetail, 9);
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 10);
            Layout(x => x.LoopN1, 11);
            Layout(x => x.LoopLM, 12);
            Layout(x => x.LoopFA1, 13);
            Layout(x => x.LoopCDD, 14);
            Segment(x => x.TransactionSetTrailer, 15);
            Segment(x => x.FunctionalGroupTrailer, 16);
        }
    }
}