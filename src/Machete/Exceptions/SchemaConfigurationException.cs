namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class SchemaConfigurationException :
        MacheteSchemaException
    {
        public SchemaConfigurationException()
        {
        }

        public SchemaConfigurationException(string message)
            : base(message)
        {
        }
        
        public SchemaConfigurationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}