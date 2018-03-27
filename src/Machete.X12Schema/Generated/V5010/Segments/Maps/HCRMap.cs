namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class HCRMap :
        X12SegmentMap<HCR, X12Entity>
    {
        public HCRMap()
        {
            Id = "HCR";
            Name = "HCR Segment";
        }
    }
}