namespace Machete.SchemaConfiguration
{
    using System;


    public class EntityValueInfo :
        ValueInfo
    {
        public EntityValueInfo(Type valueType, int position, bool isRequired, int minLength, int maxLength, FormatOptions formatting)
        {
            ValueType = valueType;
            Position = position;
            IsRequired = isRequired;
            MinLength = minLength;
            MaxLength = maxLength;
            Formatting = formatting;
        }

        public Type ValueType { get; }

        public bool IsRequired { get; }

        public int Position { get; }

        public int MinLength { get; }

        public int MaxLength { get; }

        public FormatOptions Formatting { get; }
    }
}