namespace Machete.X12Schema.V5010.Layouts
{
    using X12;
    using X12.Schema.Segments;


    public interface X12MessageLayout :
        X12Layout
    {
        Segment<ISA> ISA { get; }
        Segment<GS> GS { get; }
        Segment<ST> TransactionSetHeader { get; }
    }
}