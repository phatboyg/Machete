namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop211_944 :
        X12Layout
    {
        Segment<W13> ItemDetailException { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
    }
}