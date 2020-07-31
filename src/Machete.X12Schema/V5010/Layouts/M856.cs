namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M856 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T856> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}