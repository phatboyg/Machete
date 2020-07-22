namespace Machete.X12Schema.V5010
{
    using X12;


    public interface F812 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T812> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}