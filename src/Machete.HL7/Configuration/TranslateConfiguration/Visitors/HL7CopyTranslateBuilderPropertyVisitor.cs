namespace Machete.HL7.Configuration.TranslateConfiguration.Visitors
{
    using System.Reflection;
    using Machete.TranslateConfiguration;
    using Machete.TranslateConfiguration.Visitors;


    public class HL7CopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema> :
        CopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>,
        IHL7TranslateBuilderPropertyVisitor<TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : HL7Entity
    {
        readonly ITranslateBuilderPropertyReflector<IHL7TranslateBuilderPropertyVisitor<TSchema>, TSchema> _reflector;

        public HL7CopyTranslateBuilderPropertyVisitor(IEntityTranslateBuilder<TResult, TInput, TSchema> builder)
            : base(builder)
        {
            _reflector = new HL7EntityTranslateBuilderPropertyReflector<IHL7TranslateBuilderPropertyVisitor<TSchema>, TResult, TInput, TSchema>();
        }

        public override void Property(PropertyInfo property)
        {
            _reflector.Property(this, property);
        }

        public virtual void Segment<T>(PropertyInfo property)
            where T : HL7Segment
        {
        }

        public virtual void SegmentList<T>(PropertyInfo property)
            where T : HL7Segment
        {
        }
    }
}