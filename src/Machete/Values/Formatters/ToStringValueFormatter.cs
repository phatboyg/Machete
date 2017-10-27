namespace Machete.Values.Formatters
{
    using Machete.Formatters;


    public class ToStringValueFormatter<TValue> :
        IValueFormatter<TValue>
    {
        public void Format(FormatValueContext<TValue> context)
        {
            if (context.Value.HasValue)
            {
                var text = context.Value.Value.ToString();

                context.Append(text);
            }
        }
    }
}