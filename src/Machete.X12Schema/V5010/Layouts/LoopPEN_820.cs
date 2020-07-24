namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPEN_820 :
        X12Layout
    {
        Segment<PEN> PensionInformation { get; }
        
        Segment<AMT> MonetaryAmount { get; }
        
        Segment<DTP> DateOrTimeReference { get; }
        
        LayoutList<LoopINV_820> LoopINV { get; }
    }
}