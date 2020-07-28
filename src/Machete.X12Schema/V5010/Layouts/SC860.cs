namespace Machete.X12Schema.V5010
{
    using X12;


    public interface SC860 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T860> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}