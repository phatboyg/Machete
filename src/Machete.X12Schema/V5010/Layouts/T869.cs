namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T869 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BSI> BeginningOrderStatusInquiry { get; }
        
        Segment<NTE> NoteOrSpecialInstructions { get; }
        
        LayoutList<LoopHL_869> LoopHL { get; }
        
        Segment<CTT> TransactionTotals { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}