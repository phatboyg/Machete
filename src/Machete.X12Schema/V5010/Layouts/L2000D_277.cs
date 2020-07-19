namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000D_277 :
        X12Layout
    {
        Segment<HL> ServiceProviderLevel { get; }
        
        Layout<L2100D_277> ServiceProviderName { get; }
        
        LayoutList<L2200D_277> PayerClaimControlNumber { get; }
    }
}