namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class ValueMissingException :
        MacheteParserException
    {
        public ValueMissingException()
        {
        }

        public ValueMissingException(string message)
            : base(message)
        {
        }

        protected ValueMissingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ValueMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}