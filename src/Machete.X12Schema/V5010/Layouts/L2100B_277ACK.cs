namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2100B_277ACK :
        X12Layout
    {
        Segment<NM1> InformationReceiverName { get; }
    }
}