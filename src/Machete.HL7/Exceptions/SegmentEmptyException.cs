namespace Machete.HL7.Exceptions
{
    using System;
    using System.Runtime.Serialization;


    public class SegmentEmptyException :
        Exception
    {
        public SegmentEmptyException()
        {
        }

        public SegmentEmptyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public SegmentEmptyException(string message)
            : base(message)
        {
        }

        public SegmentEmptyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}