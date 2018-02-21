namespace Machete.X12Schema.V5010.Layouts
{
    using X12;
    using X12.Schema.Segments;


    public interface L2000B_837P :
        X12Layout
    {
        Segment<HL> SubscriberHeirarchicalLevel { get; }
        
        Segment<SBR> SubscriberInformtion { get; }
        
        Segment<PAT> PatientInformation { get; }
        
        Layout<L2010BA_837P> Subscriber { get; }
        
        Layout<L2010BB_837P> Payer { get; }
    }
}