namespace Machete.Translators.Results
{
    using System.Collections.Generic;


    public class TranslateResultCollection<TSchema> :
        ITranslateResultCollection<TSchema>
        where TSchema : Entity
    {
        readonly TranslateContext<TSchema> _context;
        readonly List<TranslateResult<TSchema>> _results;

        public TranslateResultCollection(TranslateContext<TSchema> context)
        {
            _context = context;
            _results = new List<TranslateResult<TSchema>>();
        }

        public void Add(TranslateResult<TSchema> result)
        {
            _results.Add(result);
        }

        public TranslateResult<TSchema> ToResult()
        {
            return new CompositeTranslateResult<TSchema>(_context, _results);
        }
    }
}