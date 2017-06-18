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

        #if !NETCORE
        protected ValueMissingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endif

        public ValueMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}