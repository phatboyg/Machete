namespace Machete.X12Schema.V5010.Layouts
{
    using X12;
    using X12.Schema.Segments;


    public interface L2000B_837D :
        X12Layout
    {
        Segment<HL> SubscriberHeirarchicalLevel { get; }
        
        Segment<SBR> SubscriberInformation { get; }
        
        Layout<L2010BA_837D> Subscriber { get; }
        
        Layout<L2010BB_837D> Payer { get; }
    }
}