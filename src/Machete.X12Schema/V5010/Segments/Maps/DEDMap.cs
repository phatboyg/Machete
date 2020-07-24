namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class DEDMap :
        X12SegmentMap<DED, X12Entity>
    {
        public DEDMap()
        {
            Id = "DED";
            Name = "Deductions";
            
            Value(x => x.TypeOfDeduction, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReferenceIdentification1, 2, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Amount, 4, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.ReferenceIdentification2, 5, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.YesNoConditionOrResponseCode2, 6, x => x.FixedLength(1).IsRequired());
            Value(x => x.Name, 7, x => x.MinLength(1).MaxLength(60));
            Value(x => x.ReferenceIdentification3, 8, x => x.MinLength(1).MaxLength(30));
            Value(x => x.YesNoConditionOrResponseCode3, 9, x => x.MinLength(1));
        }
    }
}