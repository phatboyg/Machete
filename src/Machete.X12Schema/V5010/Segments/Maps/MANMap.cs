namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class MANMap :
        X12SegmentMap<MAN, X12Entity>
    {
        public MANMap()
        {
            Id = "MAN";
            Name = "Marks and Numbers";
            
            Value(x => x.MarksAndNumbersQualifier1, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.MarksAndNumbers1, 2, x => x.MinLength(1).MaxLength(48).IsRequired());
            Value(x => x.MarksAndNumbers2, 3, x => x.MinLength(1).MaxLength(48));
            Value(x => x.MarksAndNumbersQualifier2, 4, x => x.MinLength(1).MaxLength(2));
            Value(x => x.MarksAndNumbers3, 5, x => x.MinLength(1).MaxLength(48));
            Value(x => x.MarksAndNumbers4, 6, x => x.MinLength(1).MaxLength(48));
        }
    }
}