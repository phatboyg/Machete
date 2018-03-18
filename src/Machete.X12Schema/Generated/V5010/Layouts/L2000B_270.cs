namespace Machete.X12Schema.V5010.Layouts
{
    using X12;
    using X12.Schema.Segments;


    public interface L2000B_270 :
        X12Layout
    {
        Segment<HL> InformationReceiverLevel { get; }
        
        Layout<L2100B_270> InformationReceiver { get; }
    }
}