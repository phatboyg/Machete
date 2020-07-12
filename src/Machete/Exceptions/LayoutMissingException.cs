namespace Machete
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class LayoutMissingException :
        MacheteException
    {
        public LayoutMissingException()
        {
        }

        public LayoutMissingException(string message)
            : base(message)
        {
        }

        public LayoutMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}