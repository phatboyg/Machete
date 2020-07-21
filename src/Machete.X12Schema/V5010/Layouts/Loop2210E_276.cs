namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2210E_276 :
        X12Layout
    {
        Segment<SVC> Information { get; }
        
        Segment<REF> ItemIdentification { get; }
        
        Segment<DTP> Date { get; }
    }
}