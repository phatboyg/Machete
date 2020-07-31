namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLX_870 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        Segment<N1> PartyIdentification { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopLM_870> LoopLM { get; }
    }
}