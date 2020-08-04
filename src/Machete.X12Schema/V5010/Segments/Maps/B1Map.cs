namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class B1Map :
        X12SegmentMap<B1, X12Entity>
    {
        public B1Map()
        {
            Id = "B1";
            Name = "Beginning Segment for Booking or Pickup/Delivery";
            
            Value(x => x.StandardCarrierAlphaCode, 1, x => x.MinLength(2).MaxLength(4).IsRequired());
            Value(x => x.ShipmentIdentificationNumber, 2, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ReservationActionCode, 4, x => x.FixedLength(1));
            Value(x => x.YesNoConditionOrResponseCode, 5, x => x.FixedLength(1));
            Value(x => x.ShipmentOrWorkAssignmentDeclineReasonCode, 6, x => x.FixedLength(3));
        }
    }
}