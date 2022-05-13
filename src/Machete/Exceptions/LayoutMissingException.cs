namespace Machete
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class LayoutMissingException :
        MacheteException
    {
        public LayoutMissingException()
        {
        }

        public LayoutMissingException(string message)
            : base(message)
        {
        }

        protected LayoutMissingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public LayoutMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}