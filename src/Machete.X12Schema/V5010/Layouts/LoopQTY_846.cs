namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopQTY_846 :
        X12Layout
    {
        Segment<QTY> QuantityInformation { get; }
        
        Segment<UIT> UnitDetail { get; }
        
        Segment<MEA> Measurements { get; }
        
        Segment<LDT> LeadTime { get; }
        
        Segment<DTM> DateOrTimeReference { get; }

        LayoutList<LoopSCH_846> LoopSCH { get; }
        
        LayoutList<LoopLM_846> LoopLM { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<LoopREF_846> LoopREF { get;  }
        
        Segment<LE> LoopTrailer { get; }
    }
}