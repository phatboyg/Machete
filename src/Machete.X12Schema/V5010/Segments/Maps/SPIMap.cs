namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SPIMap :
        X12SegmentMap<SPI, X12Entity>
    {
        public SPIMap()
        {
            Id = "SPI";
            Name = "Specification Identifier";
            
            Value(x => x.SecurityLevelCode1, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReferenceIdentificationQualifier, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 3, x => x.MinLength(1).MaxLength(50));
            Value(x => x.EntityTitle, 4, x => x.MinLength(1).MaxLength(132));
            Value(x => x.EntityPurpose, 5, x => x.MinLength(1).MaxLength(80));
            Value(x => x.EntityStatusCode, 6, x => x.FixedLength(1));
            Value(x => x.TransactionSetPurposeCode, 7, x => x.FixedLength(2));
            Value(x => x.ReportTypeCode, 8, x => x.FixedLength(2));
            Value(x => x.SecurityLevelCode2, 9, x => x.FixedLength(2));
            Value(x => x.AgencyQualifierCode, 10, x => x.FixedLength(2));
            Value(x => x.SourceSubqualifier, 11, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AssignedNumber, 12, x => x.MinLength(1).MaxLength(6));
            Value(x => x.CertificationTypeCode, 13, x => x.FixedLength(1));
            Value(x => x.ProposalDataDetailIdentifierCode, 14, x => x.MinLength(1).MaxLength(3));
            Value(x => x.HierarchicalStructureCode, 15, x => x.FixedLength(4));
        }
    }
}