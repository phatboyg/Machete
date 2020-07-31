namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M850 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T850> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}