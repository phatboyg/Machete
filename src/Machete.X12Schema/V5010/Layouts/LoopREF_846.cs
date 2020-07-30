namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopREF_846 :
        X12Layout
    {
        Segment<REF> ReferenceInformation { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        Segment<N1> PartyInformation { get;  }
        
        LayoutList<LoopLM_846> LoopLM { get; }
    }
}