namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0150_940Map :
        X12LayoutMap<Loop0150_940, X12Entity>
    {
        public Loop0150_940Map()
        {
            Id = "Loop_0150_940";
            Name = "Loop 0150";
            
            Segment(x => x.CarrierDetailsEquipment, 0);
            Segment(x => x.TrailerOrContainerDimensionAndWeight, 1);
        }
    }
}