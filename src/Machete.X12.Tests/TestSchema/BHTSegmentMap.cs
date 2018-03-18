namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class BHTSegmentMap :
        X12SegmentMap<BHTSegment, X12Entity>
    {
        public BHTSegmentMap()
        {
            Id = "BHT";
            Name = "Begin Hierarchical Transaction";
            
            Value(x => x.HierarchicalStructureCode, 1, x => x.FixedLength(4).IsRequired());
            Value(x => x.TransactionSetPurposeCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReferenceIdentification, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Date, 4, x => x.LongDate().IsRequired());
            Value(x => x.Time, 5, x => x.Time().IsRequired());
            Value(x => x.TransactionTypeCode, 6, x => x.FixedLength(2));
        }
    }
}