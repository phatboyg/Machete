namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000C_837P :
        X12Layout
    {
        Segment<HL> HierarchicalLevel { get; }
        
        Segment<PAT> PatientInformation { get; }
        
        Layout<Loop2010CA_837P> Loop2010CA { get; }
        
        LayoutList<Loop2300_837P> Loop2300 { get; }
    }
}