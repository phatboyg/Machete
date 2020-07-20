namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000B_837D :
        X12Layout
    {
        Segment<HL> HierarchicalLevel { get; }
        
        Segment<SBR> SubscriberInformation { get; }
        
        Layout<Loop2010BA_837D> Loop2010BA { get; }
        
        Layout<Loop2010BB_837D> Loop2010BB { get; }
    }
}