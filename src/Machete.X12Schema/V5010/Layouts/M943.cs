namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M943 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T943> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}