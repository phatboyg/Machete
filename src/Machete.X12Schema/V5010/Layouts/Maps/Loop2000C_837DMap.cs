namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000C_837DMap :
        X12LayoutMap<Loop2000C_837D, X12Entity>
    {
        public Loop2000C_837DMap()
        {
            Id = "2000C";
            Name = "Patient Hierarchical Level";
            
            Segment(x => x.HierarchicalLevel, 0);
            Segment(x => x.PatientInformation, 1, x => x.IsRequired());
            Layout(x => x.Loop2010CA, 2);
            Layout(x => x.Loop2300, 3);
        }
    }
}