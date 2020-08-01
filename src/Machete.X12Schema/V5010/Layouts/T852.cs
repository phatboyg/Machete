namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T852 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<XQ> ReportingDateOrAction { get; }
        
        SegmentList<XPO> PreassignedPurchaseOrderNumbers { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        LayoutList<LoopN1_852> LoopN1 { get; }
        
        LayoutList<LoopLIN_852> LoopLIN { get; }
        
        Segment<CTT> TransactionTotals { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}