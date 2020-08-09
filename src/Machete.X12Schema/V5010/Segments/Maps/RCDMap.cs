namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class RCDMap :
        X12SegmentMap<RCD, X12Entity>
    {
        public RCDMap()
        {
            Id = "RCD";
            Name = "Receiving Conditions";
            
            Value(x => x.AssignedIdentification, 1, x => x.MinLength(1).MaxLength(20));
            Value(x => x.QuantityUnitsReceivedOrAccepted, 2, x => x.MinLength(1).MaxLength(9));
            Entity(x => x.CompositeUnitOfMeasure1, 3);
            Value(x => x.QuantityUnitsReturned, 4, x => x.MinLength(1).MaxLength(9));
            Entity(x => x.CompositeUnitOfMeasure2, 5);
            Value(x => x.QuantityInQuestion1, 6, x => x.MinLength(1).MaxLength(9));
            Entity(x => x.CompositeUnitOfMeasure3, 7);
            Value(x => x.ReceivingConditionCode1, 8, x => x.FixedLength(2));
            Value(x => x.QuantityInQuestion2, 9, x => x.MinLength(1).MaxLength(9));
            Entity(x => x.CompositeUnitOfMeasure4, 10);
            Value(x => x.ReceivingConditionCode2, 11, x => x.FixedLength(2));
            Value(x => x.QuantityInQuestion3, 12, x => x.MinLength(1).MaxLength(9));
            Entity(x => x.CompositeUnitOfMeasure5, 13);
            Value(x => x.ReceivingConditionCode3, 14, x => x.FixedLength(2));
            Value(x => x.QuantityInQuestion4, 15, x => x.MinLength(1).MaxLength(9));
            Entity(x => x.CompositeUnitOfMeasure6, 16);
            Value(x => x.ReceivingConditionCode4, 17, x => x.FixedLength(2));
            Value(x => x.QuantityInQuestion5, 18, x => x.MinLength(1).MaxLength(9));
            Entity(x => x.CompositeUnitOfMeasure7, 19);
            Value(x => x.ReceivingConditionCode5, 20, x => x.FixedLength(2));
            Value(x => x.Quantity, 21, x => x.MinLength(1).MaxLength(15));
        }
    }
}