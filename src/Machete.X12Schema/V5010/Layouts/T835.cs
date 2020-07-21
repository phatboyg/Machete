namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 835 Transaction
    /// </summary>
    public interface T835 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BPR> FinancialInformation { get; }
        
        Segment<TRN> ReassociationTraceNumber { get; }
        
        Segment<CUR> ForeignCurrencyInformation { get; }
        
        Segment<REF> ReceiverIdentification { get; }
        
        Segment<REF> VersionIdentification { get; }
        
        Segment<DTM> ProductionDate { get; }
        
        LayoutList<Loop1000A_835> Loop1000A { get; }
        
        LayoutList<Loop1000B_835> Loop1000B { get; }
        
        LayoutList<Loop2000_835> Loop2000 { get; }
        
        SegmentList<PLB> ProviderAdjustment { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}