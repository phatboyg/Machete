namespace Machete.Translators.TranslateContexts
{
    using System;
    using Cursors;


    public class EntityTranslateContext<TInput, TSchema> :
        BasePayload,
        TranslateContext<TInput, TSchema>
        where TSchema : Entity
    {
        readonly Result<Cursor<TSchema>, TInput> _input;

        public EntityTranslateContext(EntityResult<TSchema> source, Result<Cursor<TSchema>, TInput> input, int? index = default(int?))
        {
            Source = source;

            _input = input;
            Index = index;
        }

        public EntityResult<TSchema> Source { get; }

        public EntityResult<TSchema> Result<TResult>(TResult result)
            where TResult : TSchema
        {
            return new TranslateResultEntityResult<TResult, TSchema>(result, Source.Schema);
        }

        public EntityResult<TSchema> Result(TSchema result, Type schemaType)
        {
            return new TranslateResultEntityResult<TSchema, TSchema>(result, Source.Schema);
        }

        public EntityResult<TSchema> Empty<TResult>()
        {
            throw new NotImplementedException();
        }

        public IEntityResultCollection<TSchema> CreateResultCollection()
        {
            throw new NotImplementedException();
        }

        public TranslateContext<TInput1, TSchema> CreateContext<TInput1>(TInput1 input, int? index = null)
        {
            throw new NotImplementedException();
        }

        public TranslateContext<TInput1, TSchema> CreateContext<TInput1>(int? index = null)
        {
            throw new NotImplementedException();
        }

        public Cursor<TSchema> Cursor => _input.Next;
        public TInput Input => _input.Value;
        public bool HasInput => _input.HasValue;
        public int? Index { get; }

        public bool TryGetContext<T>(out TranslateContext<T, TSchema> context)
        {
            throw new NotImplementedException();
        }

        public TranslateContext<TInput, TSchema> CreateScope()
        {
            throw new NotImplementedException();
        }
    }
}