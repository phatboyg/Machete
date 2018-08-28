namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 270 Healthcare Eligibility Benefit Inquiry
    /// </summary>
    public interface HEBI270 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T270> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}