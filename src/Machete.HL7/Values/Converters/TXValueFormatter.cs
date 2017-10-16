namespace Machete.HL7.Values.Converters
{
    using Machete.Formatters;


    public class TXValueFormatter :
        IValueFormatter<TX>
    {
        public void Format(FormatValueContext<TX> context)
        {
            if (context.Value.HasValue)
            {
                context.Append(context.Value.Slice);
            }
        }
    }
}