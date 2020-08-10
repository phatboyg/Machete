namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M861 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T861> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}