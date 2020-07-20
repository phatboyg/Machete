namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2330H_837D :
        X12Layout
    {
        Segment<NM1> OtherPayerAssistantSurgeon { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}