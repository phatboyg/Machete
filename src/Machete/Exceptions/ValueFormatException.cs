namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class ValueFormatException :
        MacheteParserException
    {
        public ValueFormatException()
        {
        }

        public ValueFormatException(string message)
            : base(message)
        {
        }

        protected ValueFormatException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ValueFormatException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}