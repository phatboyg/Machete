namespace Machete.Translators.Results
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Internals.Extensions;


    public class CompositeTranslateResult<TSchema> :
        TranslateResult<TSchema>
        where TSchema : Entity
    {
        readonly TranslateContext<TSchema> _context;
        readonly IReadOnlyList<TranslateResult<TSchema>> _results;
        readonly IList<IndexPosition> _positions;


        struct IndexPosition
        {
            public readonly int Index;
            public readonly int Offset;

            public IndexPosition(int index, int offset)
            {
                Index = index;
                Offset = offset;
            }
        }


        public CompositeTranslateResult(TranslateContext<TSchema> context, IReadOnlyList<TranslateResult<TSchema>> results)
        {
            _context = context;
            _results = results;

            _positions = new List<IndexPosition>(_results.Count);
        }

        public ISchema<TSchema> Schema => _context.Source.Schema;

        public bool TryGetEntity<T>(int index, out T entity)
            where T : TSchema
        {
            if (index < _positions.Count)
            {
                var position = _positions[index];
                return _results[position.Index].TryGetEntity(position.Offset, out entity);
            }

            var result = 0;
            var offset = 0;
            if (_positions.Count > 0)
            {
                var lastPosition = _positions[_positions.Count - 1];

                result = lastPosition.Index;
                offset = lastPosition.Offset + 1;
            }

            Trace.WriteLine($"Starting at {result},{offset}");

            while (index >= _positions.Count && result < _results.Count)
            {
                TSchema anyEntity;
                if (_results[result].TryGetEntity(offset, out anyEntity))
                {
                    Trace.WriteLine($"Result {_positions.Count}: {TypeCache.GetShortName(anyEntity.GetType())}");

                    _positions.Add(new IndexPosition(result, offset));
                    offset++;
                }
                else
                {
                    offset = 0;
                    result++;
                }
            }

            if (index < _positions.Count)
            {
                var position = _positions[index];
                return _results[position.Index].TryGetEntity(position.Offset, out entity);
            }

            entity = default(T);
            return false;
        }

        public bool HasContext(Type contextType)
        {
            return _context.HasContext(contextType);
        }

        public bool TryGetContext<T>(out T context)
            where T : class
        {
            return _context.TryGetContext(out context);
        }

        public bool IsTranslated => true;
        public EntityResult<TSchema> Source => _context.Source;
    }
}