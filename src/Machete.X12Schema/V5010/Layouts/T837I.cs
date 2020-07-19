namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 837I Transaction
    /// </summary>
    public interface T837I :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BHT> BeginningOfHierarchicalTransaction { get; }
        
        LayoutList<L1000A_837I> Submitter { get; }
        
        LayoutList<L1000B_837I> Receiver { get; }
        
        LayoutList<L2000A_837I> BillingProviderDetail { get; }
        
        LayoutList<L2000B_837I> SubscriberDetail { get; }
        
        LayoutList<L2000C_837I> PatientDetail { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}