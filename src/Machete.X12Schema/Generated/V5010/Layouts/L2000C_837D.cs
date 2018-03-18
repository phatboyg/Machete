namespace Machete.X12Schema.V5010.Layouts
{
    using X12;
    using X12.Schema.Segments;


    public interface L2000C_837D :
        X12Layout
    {
        Segment<HL> PatientHeirarchicalLevel { get; }
        
        Segment<PAT> PatientInformation { get; }
        
        Layout<L2010CA_837D> Patient { get; }
        
        LayoutList<L2300_837D> ClaimInformation { get; }
    }
}