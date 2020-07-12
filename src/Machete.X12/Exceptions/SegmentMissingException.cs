namespace Machete.X12.Exceptions
{
    using System;
    using System.Runtime.Serialization;


    public class SegmentMissingException :
        Exception
    {
        public SegmentMissingException()
        {
        }

        public SegmentMissingException(string message)
            : base(message)
        {
        }

        public SegmentMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}