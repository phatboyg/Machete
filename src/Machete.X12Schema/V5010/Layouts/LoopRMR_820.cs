namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopRMR_820 :
        X12Layout
    {
        Segment<RMR> RemittanceAdviceAccountsReceivableOpenItemReference { get; }
        
        SegmentList<NTE> NoteOrSpecialInstruction { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        LayoutList<LoopIT1_820> LoopIT1 { get; }
        
        LayoutList<LoopADX_2_820> LoopADX { get; }
    }
}