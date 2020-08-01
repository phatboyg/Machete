namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class PDMap :
        X12SegmentMap<PD, X12Entity>
    {
        public PDMap()
        {
            Id = "PD";
            Name = "Pricing Data";
            
            Value(x => x.UnitOfTimePeriodOrInterval, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Date, 2, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Entity(x => x.CompositeUnitOfMeasure, 3);
            Value(x => x.Quantity, 4, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.Name, 5, x => x.MinLength(1).MaxLength(60).IsRequired());
            Value(x => x.Description1, 6, x => x.MinLength(1).MaxLength(80));
            Value(x => x.BreakStructureDetailCode, 7, x => x.FixedLength(2));
            Value(x => x.ReferenceIdentification, 8, x => x.MinLength(1).MaxLength(50));
            Value(x => x.Description2, 9, x => x.MinLength(1).MaxLength(80));
            Value(x => x.ProposalDataDetailIdentifierCode, 10, x => x.MinLength(1).MaxLength(3));
        }
    }
}