namespace Machete.X12Schema.V5010
{
    using X12;


    public interface F828 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T828> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}