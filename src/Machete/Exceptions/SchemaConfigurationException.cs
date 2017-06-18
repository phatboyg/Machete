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

        #if !NETCORE
        protected SchemaConfigurationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endif
        
        public SchemaConfigurationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}