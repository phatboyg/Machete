namespace Machete.Values.Formatters
{
    using Machete.Formatters;


    public class BooleanValueFormatter :
        IValueFormatter<bool>
    {
        public void Format(FormatValueContext<bool> context)
        {
            if (!context.Value.HasValue)
                return;

            var value = context.Value.Value;

            context.Append(value.ToString());
        }
    }
}