namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000B_837I :
        X12Layout
    {
        Segment<HL> HierarchicalLevel { get; }
        
        Segment<SBR> SubscriberInformation { get; }
        
        Layout<Loop2010BA_837I> Loop2010BA { get; }
        
        Layout<Loop2010BB_837I> Loop2010BB { get; }
    }
}