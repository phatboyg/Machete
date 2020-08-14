namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L5Map :
        X12SegmentMap<L5, X12Entity>
    {
        public L5Map()
        {
            Id = "L5";
            Name = "Description, Marks and Numbers";
            
            Value(x => x.LadingLineItemNumber, 1, x => x.MinLength(1).MaxLength(3));
            Value(x => x.LadingDescription, 2, x => x.MinLength(1).MaxLength(50));
            Value(x => x.CommodityCode1, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.CommodityCodeQualifier1, 4, x => x.FixedLength(1));
            Value(x => x.PackagingCode, 5, x => x.MinLength(3).MaxLength(5));
            Value(x => x.MarksAndNumbers, 6, x => x.MinLength(1).MaxLength(48));
            Value(x => x.MarksAndNumbersQualifier, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.CommodityCodeQualifier2, 8, x => x.FixedLength(1));
            Value(x => x.CommodityCode2, 9, x => x.MinLength(1).MaxLength(30));
            Value(x => x.CompartmentIdCode, 10, x => x.FixedLength(1));
        }
    }
}