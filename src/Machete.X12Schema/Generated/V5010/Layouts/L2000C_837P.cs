namespace Machete.X12Schema.V5010.Layouts
{
    using X12;
    using X12.Schema.Segments;


    public interface L2000C_837P :
        X12Layout
    {
        Segment<HL> PatientHeirarchicalLevel { get; }
        
        Segment<PAT> PatientInformation { get; }
        
        Layout<L2010CA_837P> Patient { get; }
        
        LayoutList<L2300_837P> ClaimInformation { get; }
    }
}