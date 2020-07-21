namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 276 Transaction
    /// </summary>
    public interface T276 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BHT> BeginningOfHierarchicalTransaction { get; }
        
        LayoutList<Loop2000A_276> Loop2000A { get; }
        
        LayoutList<Loop2000B_276> Loop2000B { get; }
        
        LayoutList<Loop2000C_276> Loop2000C { get; }
        
        LayoutList<Loop2000D_276> Loop2000D { get; }
        
        LayoutList<Loop2000E_276> Loop2000E { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}