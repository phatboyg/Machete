namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000C_837D :
        X12Layout
    {
        Segment<HL> PatientHeirarchicalLevel { get; }
        
        Segment<PAT> PatientInformation { get; }
        
        Layout<L2010CA_837D> Patient { get; }
        
        LayoutList<L2300_837D> ClaimInformation { get; }
    }
}