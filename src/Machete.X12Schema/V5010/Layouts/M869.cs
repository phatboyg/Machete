namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M869 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T869> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}