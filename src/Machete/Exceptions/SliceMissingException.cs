namespace Machete
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class SliceMissingException :
        MacheteParserException
    {
        public SliceMissingException()
            : this("The slice is missing.")
        {
        }

        public SliceMissingException(string message)
            : base(message)
        {
        }
        
        public SliceMissingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}