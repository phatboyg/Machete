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

        #if !NETCORE
        protected ValueFormatException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endif

        public ValueFormatException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}