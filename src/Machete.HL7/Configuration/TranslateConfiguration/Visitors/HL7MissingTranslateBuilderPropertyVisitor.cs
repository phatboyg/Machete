namespace Machete.HL7.Configuration.TranslateConfiguration.Visitors
{
    using System.Reflection;
    using Machete.TranslateConfiguration;
    using Machete.TranslateConfiguration.Specifications;
    using Machete.TranslateConfiguration.Visitors;


    public class HL7MissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema> :
        MissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>,
        IHL7TranslateBuilderPropertyVisitor<TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : HL7Entity
    {
        readonly ITranslateBuilder<TResult, TInput, TSchema> _builder;
        readonly ITranslateBuilderPropertyReflector<IHL7TranslateBuilderPropertyVisitor<TSchema>, TSchema> _reflector;

        public HL7MissingTranslateBuilderPropertyVisitor(ITranslateBuilder<TResult, TInput, TSchema> builder)
            : base(builder)
        {
            _builder = builder;
            _reflector = new HL7EntityTranslateBuilderPropertyReflector<IHL7TranslateBuilderPropertyVisitor<TSchema>, TResult, TInput, TSchema>();
        }

        public override void Property(PropertyInfo property)
        {
            _reflector.Property(this, property);
        }

        public virtual void Segment<T>(PropertyInfo property)
            where T : HL7Segment
        {
            var specification = new SetPropertyTranslateSpecification<TResult, Segment<T>, TInput, TSchema>(property, HL7.Segment.Missing<T>());

            specification.Apply(_builder);
        }

        public virtual void SegmentList<T>(PropertyInfo property)
            where T : HL7Segment
        {
            var specification = new SetPropertyTranslateSpecification<TResult, SegmentList<T>, TInput, TSchema>(property, HL7.SegmentList.Missing<T>());

            specification.Apply(_builder);
        }
    }
}