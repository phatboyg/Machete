namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopNM1_2_820Map :
        X12LayoutMap<LoopNM1_2_820, X12Entity>
    {
        public LoopNM1_2_820Map()
        {
            Id = "Loop_NM1_2_820";
            Name = "Loop NM1";
            
            Segment(x => x.IndividualOrOrganizationName, 0);
            Segment(x => x.ReferenceIdentification, 1);
            Segment(x => x.MaintenanceType, 2);
            Layout(x => x.LoopAIN, 3);
            Layout(x => x.LoopPEN, 4);
        }
    }
}