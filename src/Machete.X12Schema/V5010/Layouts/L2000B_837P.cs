namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000B_837P :
        X12Layout
    {
        Segment<HL> SubscriberHierarchicalLevel { get; }
        
        Segment<SBR> SubscriberInformation { get; }
        
        Segment<PAT> PatientInformation { get; }
        
        Layout<L2010BA_837P> Subscriber { get; }
        
        Layout<L2010BB_837P> Payer { get; }
    }
}