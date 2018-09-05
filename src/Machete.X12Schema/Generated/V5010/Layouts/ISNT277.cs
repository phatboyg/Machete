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
        
        LayoutList<L2000A_277> InformationSourceDetail { get; }
        
        LayoutList<L2000B_277> InformationReceiverDetail { get; }
        
        LayoutList<L2000C_277> ServiceProviderDetail { get; }
        
        LayoutList<L2000D_277> PatientDetail { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}