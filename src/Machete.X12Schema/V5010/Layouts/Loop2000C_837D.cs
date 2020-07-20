namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000C_837D :
        X12Layout
    {
        Segment<HL> HierarchicalLevel { get; }
        
        Segment<PAT> PatientInformation { get; }
        
        Layout<Loop2010CA_837D> Loop2010CA { get; }
        
        LayoutList<Loop2300_837D> Loop2300 { get; }
    }
}