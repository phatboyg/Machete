namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopADX_1_820 :
        X12Layout
    {
        SegmentList<ADX> Adjustment { get; }
        
        SegmentList<NTE> NoteOrSpecialInstruction { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopREF_1_820> LoopREF { get; }
        
        LayoutList<LoopIT1_820> LoopIT1 { get; }
    }
}