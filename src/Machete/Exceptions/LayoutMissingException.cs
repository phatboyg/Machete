namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    public class LayoutMissingException :
        Exception
    {
        public LayoutMissingException()
        {
        }

        protected LayoutMissingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public LayoutMissingException(string message)
            : base(message)
        {
        }

        public LayoutMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}