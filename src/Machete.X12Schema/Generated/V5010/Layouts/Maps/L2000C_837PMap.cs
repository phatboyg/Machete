namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000C_837PMap :
        X12LayoutMap<L2000C_837P, X12Entity>
    {
        public L2000C_837PMap()
        {
            Id = "2000C";
            Name = "Patient Heirarchical Level";
            
            Segment(x => x.PatientHierarchicalLevel, 0);
            Segment(x => x.PatientInformation, 1, x => x.IsRequired());
            Layout(x => x.PatientName, 2);
            Layout(x => x.ClaimInformation, 3);
        }
    }
}