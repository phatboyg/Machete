namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PC860 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T860> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}