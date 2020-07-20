namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000B_837P :
        X12Layout
    {
        Segment<HL> HierarchicalLevel { get; }
        
        Segment<SBR> SubscriberInformation { get; }
        
        Segment<PAT> PatientInformation { get; }
        
        Layout<Loop2010BA_837P> Loop2010BA { get; }
        
        Layout<Loop2010BB_837P> Loop2010BB { get; }
    }
}