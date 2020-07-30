namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN_846 : 
        X12Layout
    {
        Segment<SLN> SublineItemDetail { get; }
        
        Segment<PID> ItemDescription { get; }
        
        Segment<MEA> Measurements { get; }
        
        Segment<PKG> MarkingPackagingOrLoading { get; }
        
        LayoutList<LoopMAN_846> LoopMAN { get; }
    }
}