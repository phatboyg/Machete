namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class PRFMap :
        X12SegmentMap<PRF, X12Entity>
    {
        public PRFMap()
        {
            Id = "PRF";
            Name = "Purchase Order Reference";
            
            Value(x => x.PurchaseOrderNumber, 1, x => x.MinLength(1).MaxLength(22).IsRequired());
            Value(x => x.ReleaseNumber, 2, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ChangeOrderSequenceNumber, 3, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Date, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.AssignedIdentification, 5, x => x.MinLength(1).MaxLength(20));
            Value(x => x.ContractNumber, 5, x => x.MinLength(1).MaxLength(30));
            Value(x => x.PurchaseOrderTypeCode, 6, x => x.FixedLength(2));
        }
    }
}