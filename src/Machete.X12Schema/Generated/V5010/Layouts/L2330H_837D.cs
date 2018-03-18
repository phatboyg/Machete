namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2330H_837D :
        X12Layout
    {
        Segment<NM1> AssistantSurgeon { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}