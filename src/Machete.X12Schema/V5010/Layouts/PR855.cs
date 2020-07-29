namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PR855 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T855> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}