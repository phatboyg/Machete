namespace Machete.Values.Formatters
{
    using Machete.Formatters;


    public class StringValueFormatter :
        IValueFormatter<string>
    {
        public void Format(FormatValueContext<string> context)
        {
            if (!context.Value.HasValue)
                return;
            
            context.Append(context.Value.Value);
        }
    }
}