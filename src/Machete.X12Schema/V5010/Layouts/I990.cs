namespace Machete.X12Schema.V5010
{
    using X12;


    public interface I990 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T990> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}