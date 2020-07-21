namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 277 Information Status Notification Transaction
    /// </summary>
    public interface ISNT277 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BHT> BeginningOfHierarchicalTransaction { get; }
        
        LayoutList<Loop2000A_277> Loop2000A { get; }
        
        LayoutList<Loop2000B_277> Loop2000B { get; }
        
        LayoutList<Loop2000C_277> Loop2000C { get; }
        
        LayoutList<Loop2000D_277> Loop2000D { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}