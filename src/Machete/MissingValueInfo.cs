namespace Machete
{
    using System;


    public class MissingValueInfo<T> :
        ValueInfo
    {
        public Type ValueType => typeof(T);
        public bool IsRequired => false;
        public int Position => -1;
        public int MinLength => -1;
        public int MaxLength => -1;
        public FormatOptions Formatting => FormatOptions.Default;
        public bool HasValue => false;
    }
}