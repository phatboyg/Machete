namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class EMSMap :
        X12SegmentMap<EMS, X12Entity>
    {
        public EMSMap()
        {
            Id = "EMS";
            Name = "Employment Position";
            
            Value(x => x.Description, 1, x => x.MinLength(1).MaxLength(80));
            Value(x => x.EmploymentClassCode, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.OccupationCode, 3, x => x.MinLength(4).MaxLength(6));
            Value(x => x.EmploymentStatusCode, 4, x => x.FixedLength(2));
            Value(x => x.ReferenceIdentificationQualifier, 5, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification1, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ReferenceIdentification2, 7, x => x.MinLength(1).MaxLength(30));
        }
    }
}