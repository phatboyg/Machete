namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 271 Healthcare Eligibility Benefit Response
    /// </summary>
    public interface HEBR271 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T271> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}