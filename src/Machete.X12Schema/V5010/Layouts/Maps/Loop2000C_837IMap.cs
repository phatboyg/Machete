namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2000C_837IMap :
        X12LayoutMap<Loop2000C_837I, X12Entity>
    {
        public Loop2000C_837IMap()
        {
            Id = "Loop_2000C_837I";
            Name = "Patient Hierarchical Level";
            
            Segment(x => x.HierarchicalLevel, 0,
                x => x.Condition = parser => parser.Where(p => p.LevelCode.IsEqualTo("23")));
            Segment(x => x.PatientInformation, 1);
            Layout(x => x.Loop2010CA, 2);
            Layout(x => x.Loop2300, 3);
        }
    }
}