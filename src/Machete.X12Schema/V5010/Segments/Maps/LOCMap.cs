namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class LOCMap :
        X12SegmentMap<LOC, X12Entity>
    {
        public LOCMap()
        {
            Id = "LOC";
            Name = "Location";

            Value(x => x.ReferenceIdentificationQualifier1, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification1, 2, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.Description1, 3, x => x.MinLength(1).MaxLength(80));
            Value(x => x.ReferenceIdentification2, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Category, 5, x => x.MinLength(1).MaxLength(6));
            Value(x => x.ReferenceIdentificationQualifier2, 6, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification3, 7, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Description2, 8, x => x.MinLength(1).MaxLength(80));
            Value(x => x.ReferenceIdentification4, 9, x => x.MinLength(1).MaxLength(30));
            Value(x => x.MeasurementValue1, 10, x => x.MinLength(1).MaxLength(20));
            Entity(x => x.CompositeUnitOfMeasure1, 11);
            Value(x => x.MeasurementValue2, 12, x => x.MinLength(1).MaxLength(20));
            Entity(x => x.CompositeUnitOfMeasure2, 13);
            Value(x => x.MeasurementValue3, 14, x => x.MinLength(1).MaxLength(20));
            Entity(x => x.CompositeUnitOfMeasure3, 15);
            Value(x => x.MeasurementValue4, 16, x => x.MinLength(1).MaxLength(20));
            Entity(x => x.CompositeUnitOfMeasure4, 17);
            Value(x => x.MeasurementValue5, 18, x => x.MinLength(1).MaxLength(20));
            Entity(x => x.CompositeUnitOfMeasure5, 19);
            Value(x => x.MeasurementValue6, 20, x => x.MinLength(1).MaxLength(20));
            Entity(x => x.CompositeUnitOfMeasure6, 21);
            Value(x => x.ReferenceIdentificationQualifier3, 22, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification5, 23, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Description3, 24, x => x.MinLength(1).MaxLength(80));
        }
    }
}