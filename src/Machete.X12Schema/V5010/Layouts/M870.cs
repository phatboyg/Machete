namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M870 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T870> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}