namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class CSMap :
        X12SegmentMap<CS, X12Entity>
    {
        public CSMap()
        {
            Id = "MAN";
            Name = "Marks and Numbers";
            
            Value(x => x.ContractNumber, 1, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ChangeOrderSequenceNumber, 2, x => x.MinLength(1).MaxLength(8));
            Value(x => x.ReleaseNumber, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ReferenceIdentificationQualifier, 4, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 5, x => x.MinLength(1).MaxLength(30));
            Value(x => x.PurchaseOrderNumber, 6, x => x.MinLength(1).MaxLength(22));
            Value(x => x.SpecialServicesCode1, 7, x => x.MinLength(2).MaxLength(10));
            Value(x => x.FreeOnBoardPointCode, 8, x => x.FixedLength(2));
            Value(x => x.Percent1, 9, x => x.MinLength(1).MaxLength(10));
            Value(x => x.Percent2, 10, x => x.MinLength(1).MaxLength(10));
            Value(x => x.MonetaryAmount, 11, x => x.MinLength(1).MaxLength(10));
            Value(x => x.TermsTypeCode1, 12, x => x.MinLength(1).MaxLength(18));
            Value(x => x.SpecialServicesCode2, 13, x => x.FixedLength(2));
            Value(x => x.UnitOrBasisForMeasurementCode, 14, x => x.MaxLength(2));
            Value(x => x.UnitPrice, 15, x => x.MinLength(1).MaxLength(17));
            Value(x => x.TermsTypeCode2, 16, x => x.FixedLength(2));
            Value(x => x.YesNoConditionOrResponseCode1, 17, x => x.FixedLength(1));
            Value(x => x.YesNoConditionOrResponseCode2, 18, x => x.FixedLength(1));
        }
    }
}