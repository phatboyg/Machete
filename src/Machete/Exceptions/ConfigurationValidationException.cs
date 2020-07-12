namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class ConfigurationValidationException :
        MacheteException
    {
        public ConfigurationValidationException()
        {
        }

        public ConfigurationValidationException(string message)
            : base(message)
        {
        }
        
        public ConfigurationValidationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}