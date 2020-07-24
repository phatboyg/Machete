namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopREF_2_820 :
        X12Layout
    {
        Segment<REF> ReferenceIdentification { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
    }
}