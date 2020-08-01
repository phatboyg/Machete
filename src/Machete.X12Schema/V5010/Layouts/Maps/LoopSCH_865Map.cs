namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSCH_865Map :
        X12LayoutMap<LoopSCH_865, X12Entity>
    {
        public LoopSCH_865Map()
        {
            Id = "Loop_SCH_865";
            Name = "Loop SCH";
            
            Segment(x => x.LineItemSchedule, 0);
            Segment(x => x.CarrierDetailsQuantityAndWeight, 1);
            Segment(x => x.CarrierDetailsRoutingSequenceOrTransitTime, 2);
            Segment(x => x.CarrierDetailsEquipment, 3);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 4);
            Segment(x => x.ReferenceInformation, 5);
        }
    }
}