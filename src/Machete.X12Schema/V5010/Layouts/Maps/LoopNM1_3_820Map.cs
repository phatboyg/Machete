namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopNM1_3_820Map :
        X12LayoutMap<LoopNM1_3_820, X12Entity>
    {
        public LoopNM1_3_820Map()
        {
            Id = "Loop_NM1_3_820";
            Name = "Loop NM1";
            
            Segment(x => x.IndividualOrOrganizationName, 0);
            Layout(x => x.LoopLOC, 1);
            Layout(x => x.LoopASM, 2);
        }
    }
}