namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 835 Healthcare Claim Payment/Advice
    /// </summary>
    public interface HCPA835 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BPR> FinancialInformation { get; }
        
        Segment<TRN> ReassociationTraceNumber { get; }
        
        Segment<CUR> ForeignCurrencyInformation { get; }
        
        Segment<REF> ReceiverIdentification { get; }
        
        Segment<REF> VersionIdentification { get; }
        
        Segment<DTM> ProductionDate { get; }
        
        LayoutList<L1000A_835> PayerIdentification { get; }
        
        LayoutList<L1000B_835> PayeeIdentification { get; }
        
        LayoutList<L2000_835> HeaderNumber { get; }
        
        SegmentList<PLB> ProviderAdjustment { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}