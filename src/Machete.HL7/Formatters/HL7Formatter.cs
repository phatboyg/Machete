namespace Machete.HL7.Formatters
{
    using System.IO;
    using System.Threading.Tasks;


    public class HL7Formatter<TSchema> :
        IFormatter<TSchema>
        where TSchema : HL7Entity
    {
        readonly ISchema<TSchema> _schema;

        public HL7Formatter(ISchema<TSchema> schema)
        {
            _schema = schema;
        }

        public async Task<FormatResult<TSchema>> FormatAsync(Stream output, EntityResult<TSchema> input)
        {
            var settings = new HL7FormatterSettings();

            using (var writer = new StreamWriter(output))
            {
                for (int i = 0;; i++)
                {
                    TSchema entity;
                    if (!input.TryGetEntity(i, out entity))
                        break;

                    if (i > 0)
                        await writer.WriteAsync(settings.SegmentSeparator);

//                    FormatSegment(writer, segment);
                }
            }

            return new HL7FormatResult<TSchema>();
        }
    }
}