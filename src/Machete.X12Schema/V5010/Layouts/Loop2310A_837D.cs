namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2310A_837D :
        X12Layout
    {
        Segment<NM1> ReferringProvider { get; }
        
        Segment<PRV> SpecialtyInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}