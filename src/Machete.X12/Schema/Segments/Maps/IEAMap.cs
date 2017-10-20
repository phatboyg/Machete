namespace Machete.X12.Schema.Segments.Maps
{
    using Configuration;


    public class IEAMap :
        X12SegmentMap<IEA, X12Entity>
    {
        public IEAMap()
        {
            Id = "IEA";

            Name = "Interchange Control Trailer";

            Value(x => x.FunctionalGroupCount, 1, x => x.IsRequired().MinLength(1).MaxLength(5));
            Value(x => x.ControlNumber, 2, x => x.IsRequired().MinLength(4).MaxLength(9));
        }
    }
}