namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000C_837I :
        X12Layout
    {
        Segment<HL> PatientHeirarchicalLevel { get; }
        
        Segment<PAT> PatientInformation { get; }
        
        Layout<L2010CA_837I> Patient { get; }
        
        LayoutList<L2300_837I> ClaimInformation { get; }
    }
}