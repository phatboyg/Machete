namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2330C_837I :
        X12Layout
    {
        Segment<NM1> OtherPayerAttendingProvider { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}