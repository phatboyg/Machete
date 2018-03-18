namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class TOOMap :
        X12SegmentMap<TOO, X12Entity>
    {
        public TOOMap()
        {
            Id = "TOO";
            Name = "Tooth Information";

            Value(x => x.CodeListQualifierCode, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.ToothCode, 2, x => x.MinLength(1).MaxLength(30).IsRequired());
            Entity(x => x.ToothSurface, 3);
        }
    }
}