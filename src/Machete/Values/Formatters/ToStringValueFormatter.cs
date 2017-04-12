namespace Machete.Values.Formatters
{
    public class ToStringValueFormatter<TValue> :
        IValueFormatter<TValue>
    {
        public bool TryGetString(Value<TValue> value, out string text)
        {
            if (value.HasValue)
            {
                text = value.Value.ToString();
                return true;
            }

            text = null;
            return false;
        }
    }
}