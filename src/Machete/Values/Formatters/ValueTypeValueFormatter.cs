namespace Machete.Values.Formatters
{
    using System;
    using System.Globalization;


    public class ValueTypeValueFormatter<TValue> :
        IValueFormatter<TValue>
        where TValue : IFormattable
    {
        string _format;

        public ValueTypeValueFormatter(string format)
        {
            _format = format ?? "G";
        }

        public string Format
        {
            get { return _format; }
            set { _format = value; }
        }

        public bool TryGetString(Value<TValue> value, out string text)
        {
            if (value.HasValue)
            {
                text = value.Value.ToString(_format, CultureInfo.InvariantCulture);
                return true;
            }

            text = null;
            return false;
        }
    }
}