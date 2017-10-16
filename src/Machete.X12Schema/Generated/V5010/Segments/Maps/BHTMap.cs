namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;


    public class BHTMap : X12SegmentMap<BHT, X12Entity>
    {
        public BHTMap()
        {
            Id = "BHT";
            Name = "Begin Hierarchical Transaction";
            Value(x => x.HierarchicalStructureCode, 1, x => x.FixedLength(4).IsRequired());
            Value(x => x.TransactionSetPurposeCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReferenceIdentification, 3, x => x.MinLength(1).MaxLength(30));

            // TODO
            // Value(x => x.Date).LongDateTime(4, 5);
            Value(x => x.Date, 4, x => x.LongDate());
            Value(x => x.TransactionTypeCode, 6, x => x.FixedLength(2));
        }
    }
}