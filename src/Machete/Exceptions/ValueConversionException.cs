namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class ValueConversionException :
        MacheteException
    {
        public ValueConversionException()
        {
        }

        public ValueConversionException(string message)
            : base(message)
        {
        }

        protected ValueConversionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ValueConversionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}