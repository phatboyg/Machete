namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 837 Healthcare Claim Institutional
    /// </summary>
    public interface HC837I :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T837I> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}