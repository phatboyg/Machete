namespace Machete.Layouts.Parsers
{
    using System.Collections.Generic;
    using System.Linq;


    public class LayoutParser<TLayout, TSchema> :
        IParser<TSchema, TLayout>
        where TSchema : Entity
        where TLayout : Layout
    {
        readonly ILayoutFactory<TLayout> _factory;
        readonly IParser<TSchema, LayoutMatch<TLayout>>[] _parsers;

        public LayoutParser(ILayoutFactory<TLayout> factory, IEnumerable<IParser<TSchema, LayoutMatch<TLayout>>> parsers)
        {
            _factory = factory;
            _parsers = parsers.ToArray();
        }

        public Result<Cursor<TSchema>, TLayout> Parse(Cursor<TSchema> input)
        {
            var matches = new List<LayoutMatch<TLayout>>(_parsers.Length);

            var next = input;
            for (int i = 0; i < _parsers.Length; i++)
            {
                var result = _parsers[i].Parse(next);

                if (result.HasResult == false)
                    return new Unmatched<Cursor<TSchema>, TLayout>(next);

                matches.Add(result.Result);

                next = result.Next;
            }

            var layout = _factory.Create();
            for (int i = 0; i < matches.Count; i++)
                matches[i].Apply(layout);

            return new Success<Cursor<TSchema>, TLayout>(layout, next);
        }
    }
}