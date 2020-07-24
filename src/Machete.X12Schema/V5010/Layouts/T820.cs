namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T820 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BPR> BeginningPaymentOrderOrRemittanceAdvice { get; }
        
        SegmentList<NTE> NoteOrSpecialInstruction { get; }
        
        Segment<TRN> Trace { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopN1_1_820> LoopN1 { get; }
        
        LayoutList<LoopENT_820> LoopENT { get; }
        
        LayoutList<LoopTXP_820> LoopTXP { get; }
        
        LayoutList<LoopDED_820> LoopDED { get; }
        
        LayoutList<LoopLX_820> LoopLX { get; }
        
        LayoutList<LoopN9_820> LoopN9 { get; }
        
        LayoutList<LoopRYL_820> LoopRYL { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}