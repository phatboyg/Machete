namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

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