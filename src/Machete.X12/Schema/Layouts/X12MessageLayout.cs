namespace Machete.X12.Schema.Layouts
{
    using Segments;


    public interface X12MessageLayout :
        X12Layout
    {
        Segment<ISA> ISA { get; }
        Segment<GS> GS { get; }
        Segment<ST> TransactionSetHeader { get; }
    }
}