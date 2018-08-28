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
        
        Segment<BHT> BeginningOfHeirarchicalTransaction { get; }
        
        LayoutList<L2000A_276> InformationSourceDetail { get; }
        
        LayoutList<L2000B_276> InformationReceiverDetail { get; }
        
        LayoutList<L2000C_276> ServiceProviderDetail { get; }
        
        LayoutList<L2000D_276> SubscriberDetail { get; }
        
        LayoutList<L2000E_276> DependentDetail { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}