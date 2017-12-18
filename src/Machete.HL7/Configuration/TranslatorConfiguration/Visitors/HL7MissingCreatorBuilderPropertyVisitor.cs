namespace Machete.HL7.TranslatorConfiguration.Visitors
{
    using System.Reflection;
    using Machete.TranslatorConfiguration;
    using Machete.TranslatorConfiguration.Specifications;
    using Machete.TranslatorConfiguration.Visitors;


    public class HL7MissingCreatorBuilderPropertyVisitor<TResult, TSchema> :
        MissingCreatorBuilderPropertyVisitor<TResult, TSchema>,
        IHL7TranslateBuilderPropertyVisitor<TSchema>
        where TResult : TSchema
        where TSchema : HL7Entity
    {
        readonly IEntityCreatorBuilder<TResult, TSchema> _builder;
        readonly ITranslateBuilderPropertyReflector<HL7MissingCreatorBuilderPropertyVisitor<TResult, TSchema>, TSchema> _reflector;

        public HL7MissingCreatorBuilderPropertyVisitor(IEntityCreatorBuilder<TResult, TSchema> builder)
            : base(builder)
        {
            _builder = builder;
            _reflector = new HL7EntityTranslateBuilderPropertyReflector<HL7MissingCreatorBuilderPropertyVisitor<TResult, TSchema>, TSchema>();
        }

        public override void Property(PropertyInfo property)
        {
            _reflector.Property(this, property);
        }

        public virtual void Segment<T>(PropertyInfo property)
            where T : HL7Segment
        {
            var specification = new SetPropertyCreatorSpecification<TResult, Segment<T>, TSchema>(property, HL7.Segment.Missing<T>());

            specification.Apply(_builder);
        }

        public virtual void SegmentList<T>(PropertyInfo property)
            where T : HL7Segment
        {
            var specification = new SetPropertyCreatorSpecification<TResult, SegmentList<T>, TSchema>(property, HL7.SegmentList.Missing<T>());

            specification.Apply(_builder);
        }
    }
}