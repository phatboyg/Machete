namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0320_945 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        Segment<MAN> MarksAndNumbersInformation { get; }
        
        Segment<PAL> PalletTypeAndLoadCharacteristics { get; }
        
        Segment<N9> ExtendedReferenceInformation { get; }
    }
}