namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2200A_277ACK :
        X12Layout
    {
        Segment<TRN> TransmissionReceiptControlIdentifier { get; }
        
        Segment<DTP> InformationSourceReceiptDate { get; }
        
        Segment<DTP> InformationSourceProcessDate { get; }
    }
}