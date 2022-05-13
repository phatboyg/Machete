namespace Machete.HL7
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class SegmentMissingException :
        MacheteException
    {
        public SegmentMissingException()
        {
        }

        public SegmentMissingException(string message)
            : base(message)
        {
        }

        public SegmentMissingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public SegmentMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}