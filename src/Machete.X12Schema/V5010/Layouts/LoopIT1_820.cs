namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopIT1_820 :
        X12Layout
    {
        Segment<IT1> BaselineItemData { get; }
        
        Segment<RPA> RateAmountsOrPercents { get; }
        
        Segment<QTY> QuantityInformation { get; }
        
        LayoutList<LoopREF_2_820> LoopREF { get; }
        
        LayoutList<LoopSAC_820> LoopSAC { get; }
        
        LayoutList<LoopSLN_820> LoopSLN { get; }
    }
}