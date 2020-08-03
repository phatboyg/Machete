namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0200_944 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        Segment<PAL> PalletTypeAndLoadCharacteristics { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        LayoutList<Loop210_944> Loop210 { get; }
    }
}