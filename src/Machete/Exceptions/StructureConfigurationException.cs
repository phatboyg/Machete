namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class StructureConfigurationException :
        MacheteStructureException
    {
        public StructureConfigurationException()
        {
        }

        public StructureConfigurationException(string message)
            : base(message)
        {
        }

        protected StructureConfigurationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public StructureConfigurationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}