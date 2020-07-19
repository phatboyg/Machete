namespace Machete.X12Schema.V5010
{
    using X12;


    public interface FI810 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T810> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}