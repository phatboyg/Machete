namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 277 Claim Acknowledgement
    /// </summary>
    public interface HCA277 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BHT> BeginningOfHeirarchicalTransaction { get; }
        
        LayoutList<L2000A_277ACK> InformationSourceDetail { get; }
        
        LayoutList<L2000B_277ACK> InformationReceiverDetail { get; }
        
        LayoutList<L2000C_277ACK> BillingProviderOfServiceDetail { get; }
        
        LayoutList<L2000D_277ACK> PatientDetail { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}