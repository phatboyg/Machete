namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class IEASegmentMap :
        X12SegmentMap<IEASegment, X12Entity>
    {
        public IEASegmentMap()
        {
            Id = "IEA";
            Name = "Interchange Control Trailer";

            Value(x => x.FunctionalGroupCount, 1, x => x.IsRequired().MinLength(1).MaxLength(5));
            Value(x => x.ControlNumber, 2, x => x.IsRequired().MinLength(4).MaxLength(9));
        }
    }
}