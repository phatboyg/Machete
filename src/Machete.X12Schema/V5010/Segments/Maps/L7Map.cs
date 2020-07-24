namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class L7Map :
        X12SegmentMap<L7, X12Entity>
    {
        public L7Map()
        {
            Id = "L7";
            Name = "Tariff Reference";
            
            Value(x => x.LadingLineItemNumber, 1, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TariffAgencyCode, 2, x => x.MinLength(1).MaxLength(4));
            Value(x => x.TariffNumber, 3, x => x.MinLength(1).MaxLength(7));
            Value(x => x.TariffSectionNumber, 4, x => x.MinLength(1).MaxLength(2));
            Value(x => x.TariffItemNumber, 5, x => x.MinLength(1).MaxLength(16));
            Value(x => x.TariffItemPart, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.FreightClassCode, 7, x => x.MinLength(2).MaxLength(5));
            Value(x => x.TariffSupplementIdentifier, 8, x => x.MinLength(1).MaxLength(4));
            Value(x => x.ExParte, 9, x => x.FixedLength(4));
            Value(x => x.Date, 10, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.RateBasisNumber, 11, x => x.MinLength(1).MaxLength(6));
            Value(x => x.TariffColumn, 12, x => x.MinLength(1).MaxLength(2));
            Value(x => x.TariffDistance, 13, x => x.MinLength(1).MaxLength(5));
            Value(x => x.DistanceQualifier, 14, x => x.FixedLength(1));
            Value(x => x.CityName, 15, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode, 16, x => x.FixedLength(2));
        }
    }
}