namespace Machete.X12
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class DateTimePeriod :
        IComparable<string>,
        ISerializable,
        IComparable<DateTimePeriod>,
        IEquatable<DateTimePeriod>
    {
        readonly string Text;

        public DateTimePeriod()
        {
        }

        public DateTimePeriod(SerializationInfo info, StreamingContext context)
        {
            Text = info.GetString("Text");
        }

        public DateTimePeriod(string text)
        {
            Text = text;
        }

        public int CompareTo(DateTimePeriod other) => string.Compare(Text, other.Text, StringComparison.Ordinal);

        public bool Equals(DateTimePeriod other)
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
            
            if (obj.GetType() != typeof(DateTimePeriod))
                return false;

            return Equals((DateTimePeriod)obj);
        }

        public override int GetHashCode() => Text != null ? Text.GetHashCode() : 0;

        public override string ToString() => Text ?? string.Empty;

        public int CompareTo(string other) => string.Compare(Text, other, StringComparison.Ordinal);

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Text", Text);
        }

        public static bool operator ==(DateTimePeriod left, DateTimePeriod right) => Equals(left, right);

        public static bool operator !=(DateTimePeriod left, DateTimePeriod right) => !Equals(left, right);

        public static bool operator <(DateTimePeriod left, DateTimePeriod right) => string.CompareOrdinal(left.Text, right.Text) < 0;

        public static bool operator >(DateTimePeriod left, DateTimePeriod right) => string.CompareOrdinal(left.Text, right.Text) > 0;

        public static implicit operator DateTimePeriod(string value) => new DateTimePeriod(value);

        public static implicit operator string(DateTimePeriod value) => value == null ? null : value.Text;
    }
}