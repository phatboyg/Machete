namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000A_277 :
        X12Layout
    {
        Segment<HL> InformationSourceLevel { get; }
        
        Layout<L2100A_277> PayerName { get; }
    }
}