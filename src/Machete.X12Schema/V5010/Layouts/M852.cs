namespace Machete.X12Schema.V5010
{
    using X12;


    public interface M852 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T852> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}