namespace Machete.X12.Configuration
{
    public abstract class X12SegmentTranslation<TResult, TInput, TSchema> :
        X12EntityTranslation<TResult, TInput, TSchema>
        where TSchema : X12Entity
        where TInput : TSchema, X12Segment
        where TResult : TSchema, X12Segment
    {
        protected X12SegmentTranslation()
        {
        }
    }
}