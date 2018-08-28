namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 837 Healthcare Claim Dental
    /// </summary>
    public interface HC837D :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T837D> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}