namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 837D Transaction
    /// </summary>
    public interface T837D :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BHT> BeginningOfHierarchicalTransaction { get; }
        
        LayoutList<Loop1000A_837D> Loop1000A { get; }
        
        LayoutList<Loop1000B_837D> Loop1000B { get; }
        
        LayoutList<Loop2000A_837D> Loop2000A { get; }
        
        LayoutList<Loop2000B_837D> Loop2000B { get; }
        
        LayoutList<Loop2000C_837D> Loop2000C { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}