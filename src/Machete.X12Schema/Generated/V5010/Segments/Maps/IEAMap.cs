namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Schema.Segments;


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