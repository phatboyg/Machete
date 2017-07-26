namespace Machete.HL7.Tests.Segments
{
    public class NumericArraySegmentMap :
        HL7SegmentMap<NumericArraySegment, HL7Entity>
    {
        public NumericArraySegmentMap()
        {
            Id = "NAX";

            Name = "Numeric Array";

            Entity(x => x.Array1, 1);
            Entity(x => x.Array2, 2);
            Entity(x => x.Array3, 3);
        }
    }
}