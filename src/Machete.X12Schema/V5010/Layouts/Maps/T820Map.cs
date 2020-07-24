namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T820Map :
        X12LayoutMap<T820, X12Entity>
    {
        public T820Map()
        {
            Id = "T828";
            Name = "828 Debit Authorization";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningPaymentOrderOrRemittanceAdvice, 2);
            Segment(x => x.NoteOrSpecialInstruction, 3);
            Segment(x => x.Trace, 4);
            Segment(x => x.Currency, 5);
            Segment(x => x.ReferenceIdentification, 6);
            Segment(x => x.DateOrTimeReference, 7);
            Layout(x => x.LoopN1, 8);
            Layout(x => x.LoopENT, 9);
            Layout(x => x.LoopTXP, 10);
            Layout(x => x.LoopDED, 11);
            Layout(x => x.LoopLX, 12);
            Layout(x => x.LoopN9, 13);
            Layout(x => x.LoopRYL, 14);
            Segment(x => x.TransactionSetTrailer, 15);
            Segment(x => x.FunctionalGroupTrailer, 16);
        }
    }
}