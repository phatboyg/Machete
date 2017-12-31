namespace Machete.Layouts
{
    using System;


    public class UnbuiltLayoutParserFactory<TLayout, TSchema> :
        ILayoutParserFactory<TLayout, TSchema>
        where TSchema : Entity
        where TLayout : Layout
    {
        readonly Lazy<ILayoutParserFactory<TLayout, TSchema>> _layout;

        public UnbuiltLayoutParserFactory(Func<ILayoutParserFactory<TLayout, TSchema>> layoutFactory)
        {
            _layout = new Lazy<ILayoutParserFactory<TLayout, TSchema>>(layoutFactory);
        }

        public IParser<TSchema, TLayout> CreateParser(LayoutParserOptions options, IQueryBuilder<TSchema> queryBuilder)
        {
            return _layout.Value.CreateParser(options, queryBuilder);
        }

        public Type LayoutType => typeof(TLayout);
    }
}