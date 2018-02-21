namespace Machete.X12.Tests.TestSchema
{
    using Schema.Segments;


    public interface TestX12Layout :
        X12Layout
    {
        Segment<ISA> ISA { get; }
        Segment<GS> GS { get; }
        Segment<HL> HL { get; }
    }
}