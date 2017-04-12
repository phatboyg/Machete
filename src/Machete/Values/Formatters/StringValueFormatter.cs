namespace Machete.Values.Formatters
{
    public class StringValueFormatter :
        IValueFormatter<string>
    {
        public bool TryGetString(Value<string> value, out string text)
        {
            if (value.HasValue)
            {
                text = value.Value;
                return true;
            }

            text = null;
            return false;
        }
    }
}