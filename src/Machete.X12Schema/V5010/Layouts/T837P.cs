namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 837P Transaction
    /// </summary>
    public interface T837P :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BHT> BeginningOfHierarchicalTransaction { get; }
        
        LayoutList<Loop1000A_837P> Loop1000A { get; }
        
        LayoutList<Loop1000B_837P> Loop1000B { get; }
        
        LayoutList<Loop2000A_837P> Loop2000A { get; }
        
        LayoutList<Loop2000B_837P> Loop2000B { get; }
        
        LayoutList<Loop2000C_837P> Loop2000C { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}