namespace Machete.X12Schema.V5010
{
    using X12;


    public interface IN810 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T810> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}