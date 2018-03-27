namespace Machete.X12Schema.V5010
{
    using X12;


    public interface X12MessageLayout :
        X12Layout
    {
        Segment<ISA> ISA { get; }
        Segment<GS> GS { get; }
        Segment<ST> TransactionSetHeader { get; }
    }
}