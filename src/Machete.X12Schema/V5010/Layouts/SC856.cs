namespace Machete.X12Schema.V5010
{
    using X12;


    public interface SC856 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T856> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}