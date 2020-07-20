namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2440_837P :
        X12Layout
    {
        Segment<LQ> FormIdentificationCode { get; }
        
        SegmentList<FRM> SupportingDocumentation { get; }
    }
}