namespace Machete.X12Schema.V5010
{
    using X12;


    public interface CD812 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T812> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}