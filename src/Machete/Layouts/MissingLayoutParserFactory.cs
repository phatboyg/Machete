namespace Machete.Layouts
{
    using System;
    using Parsers;


    public class MissingLayoutParserFactory<TLayout, TSchema> :
        ILayoutParserFactory<TLayout, TSchema>
        where TSchema : Entity
        where TLayout : Layout
    {
        readonly MissingLayoutParser<TLayout, TSchema> _parser;

        public MissingLayoutParserFactory()
        {
            _parser = new MissingLayoutParser<TLayout, TSchema>();
        }

        public IParser<TSchema, TLayout> CreateParser(LayoutParserOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            return _parser;
        }

        public Type LayoutType => typeof(TLayout);
    }
}