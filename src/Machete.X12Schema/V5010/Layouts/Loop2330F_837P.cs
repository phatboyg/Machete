namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2330F_837P :
        X12Layout
    {
        Segment<NM1> OtherPayerSupervisingProvider { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}