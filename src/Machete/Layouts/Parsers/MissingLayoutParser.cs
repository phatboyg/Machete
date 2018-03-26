namespace Machete.Layouts.Parsers
{
    public class MissingLayoutParser<TLayout, TSchema> :
        IParser<TSchema, TLayout>
        where TSchema : Entity
        where TLayout : Layout
    {
        public Result<Cursor<TSchema>, TLayout> Parse(Cursor<TSchema> input)
        {
            return new Unmatched<Cursor<TSchema>, TLayout>(input);
        }
    }
}