namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000C_837I :
        X12Layout
    {
        Segment<HL> HierarchicalLevel { get; }
        
        Segment<PAT> PatientInformation { get; }
        
        Layout<Loop2010CA_837I> Loop2010CA { get; }
        
        LayoutList<Loop2300_837I> Loop2300 { get; }
    }
}