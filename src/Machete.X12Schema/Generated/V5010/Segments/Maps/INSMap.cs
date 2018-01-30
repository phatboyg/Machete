namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class INSMap :
        X12SegmentMap<INS, X12Entity>
    {
        public INSMap()
        {
            Id = "INS";
            Name = "Insured Benefit";
            
            Value(x => x.ConditionOrResponseCode1, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.IndividualRelationshipCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.MaintenanceTypeCode, 3, x => x.FixedLength(3));
            Value(x => x.MaintenanceReasonCode, 4, x => x.MinLength(2).MaxLength(3));
            Value(x => x.StudentStatusCode, 9, x => x.FixedLength(1));
            Value(x => x.ConditionOrResponseCode2, 10, x => x.FixedLength(1));
            Value(x => x.Number, 17, x => x.MinLength(1).MaxLength(9));
        }
    }
}