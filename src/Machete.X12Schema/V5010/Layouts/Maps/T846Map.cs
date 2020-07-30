namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T846Map :
        X12LayoutMap<T846, X12Entity>
    {
        public T846Map()
        {
            Id = "T846";
            Name = "T846";
            Segment(x => x.FunctionalGroupHeader, 0);
            
            Segment(x => x.TransactionSetHeader, 1);
            
            Segment(x => x.BeginningInventoryInvoice, 2);
            
            Segment(x => x.Currency, 3);
            
            Segment(x => x.DateOrTimeReference, 4);
            
            Segment(x => x.ReferenceInformation, 5);
            
            Segment(x => x.AdministrativeCommunicationsContact, 6);
            
            Segment(x => x.Measurements, 7);
            
            Layout(x => x.LoopN1, 8);
            
            Layout(x => x.LoopLM, 9);
            
            Layout(x => x.LoopLIN, 10);
            
            Segment(x => x.TransactionTotals, 11);
            
            Segment(x => x.TransactionSetTrailer, 12);
        }
    }
}