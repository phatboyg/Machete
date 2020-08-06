namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M947 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T947> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}