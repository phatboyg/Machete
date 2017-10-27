namespace Machete.Values.Formatters
{
    using Machete.Formatters;


    public class StringValueFormatter :
        IValueFormatter<string>
    {
        public void Format(FormatValueContext<string> context)
        {
            if (context.Value.HasValue)
            {
                context.Append(context.Value.Slice);
            }
        }
    }
}