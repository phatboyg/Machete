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

        public ValueConversionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}