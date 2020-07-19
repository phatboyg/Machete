namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2440_837P :
        X12Layout
    {
        Segment<LQ> Code { get; }
        
        SegmentList<FRM> SupportingDocumentation { get; }
    }
}