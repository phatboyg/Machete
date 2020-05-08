namespace Machete.HL7
{
    using System;
    using System.Runtime.Serialization;
    using Types;


    [Serializable]
    public class FT :
        BaseHL7Text,
        IComparable<FT>,
        IEquatable<FT>
    {
        public FT()
        {
        }

        public FT(string text)
            : base(text)
        {
        }

        protected FT(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public int CompareTo(FT other) => string.Compare(Text, other.Text, StringComparison.Ordinal);

        public bool Equals(FT other)
        {
            if (ReferenceEquals(null, other))
                return false;
            
            if (ReferenceEquals(this, other))
                return true;

            return Equals(other.Text, Text);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            
            if (ReferenceEquals(this, obj))
                return true;
            
            if (obj.GetType() != typeof(FT))
                return false;

            return Equals((FT)obj);
        }

        public override int GetHashCode()
        {
            return Text != null
                ? Text.GetHashCode()
                : 0;
        }


        public static ValueList<FT> FromString(ValueList<string> source)
        {
//            return Repeating.Values<FT, string>(source, x => x);
            throw new NotImplementedException();
        }

        public static implicit operator FT(string value) => new FT(value);

        public static implicit operator string(FT value)
        {
            if (value == null)
                return null;

            return value.Text;
        }
    }
}