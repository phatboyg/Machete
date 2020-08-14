namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Y7Map :
        X12SegmentMap<Y7, X12Entity>
    {
        public Y7Map()
        {
            Id = "Y7";
            Name = "Space Booking Cancellation";
            
            Value(x => x.BookingNumber, 1, x => x.MinLength(1).MaxLength(17).IsRequired());
        }
    }
}