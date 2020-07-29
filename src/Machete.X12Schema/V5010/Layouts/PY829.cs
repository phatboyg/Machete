namespace Machete.X12Schema.V5010
{
    using X12;


    public interface PY829 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T829> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}