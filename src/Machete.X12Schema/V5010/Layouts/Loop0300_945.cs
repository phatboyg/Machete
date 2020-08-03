namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0300_945 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        Segment<PAL> PalletTypeAndLoadCharacteristics { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        LayoutList<Loop0310_945> Loop0310 { get; }
    }
}