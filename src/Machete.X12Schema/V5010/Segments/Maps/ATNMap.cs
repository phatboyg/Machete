namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ATNMap :
        X12SegmentMap<ATN, X12Entity>
    {
        public ATNMap()
        {
            Id = "ATN";
            Name = "Attendance";
            
            Value(x => x.Quantity, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.UnitOrBasisOfMeasurement, 2, x => x.FixedLength(2));
            Value(x => x.QuantityQualifier, 3, x => x.FixedLength(2));
            Value(x => x.FrequencyCode, 4, x => x.FixedLength(1));
            Value(x => x.AttendanceTypeCode, 5, x => x.MinLength(1).MaxLength(4));
            Value(x => x.Description, 6, x => x.MinLength(1).MaxLength(80));
        }
    }
}