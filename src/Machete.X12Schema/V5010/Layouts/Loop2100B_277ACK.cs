namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2100B_277ACK :
        X12Layout
    {
        Segment<NM1> InformationReceiverName { get; }
    }
}