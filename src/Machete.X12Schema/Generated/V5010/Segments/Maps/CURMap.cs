namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class CURMap : X12SegmentMap<CUR, X12Entity>
    {
        public CURMap()
        {
            Id = "CUR";
            Name = "Currency";
            Value(x => x.EntityIdentifierCode, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.CurrencyCode, 2, x => x.FixedLength(3).IsRequired());
        }
    }
}