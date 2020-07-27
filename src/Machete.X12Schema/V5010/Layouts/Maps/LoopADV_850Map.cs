namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopADV_850Map :
        X12LayoutMap<LoopADV_850, X12Entity>
    {
        public LoopADV_850Map()
        {
            Id = "Loop_ADV_850";
            Name = "Loop ADV";
            
            Segment(x => x.AdvertisingDemographicInformation, 0);
            Segment(x => x.DateOrTimeReference, 1);
            Segment(x => x.Text, 2);
        }
    }
}