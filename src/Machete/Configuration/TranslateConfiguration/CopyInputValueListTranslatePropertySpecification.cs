namespace Machete.TranslateConfiguration
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Reflection;
    using Configuration;
    using Translators;


    public class CopyInputValueListTranslatePropertySpecification<TResult, TValue, TInput, TSchema> :
        TranslatePropertySpecification<TResult, ValueList<TValue>, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        public CopyInputValueListTranslatePropertySpecification(Expression<Func<TResult, ValueList<TValue>>> propertyExpression) :
            base(propertyExpression)
        {
        }

        public CopyInputValueListTranslatePropertySpecification(PropertyInfo propertyInfo) :
            base(propertyInfo)
        {
        }

        public CopyInputValueListTranslatePropertySpecification(Expression<Func<TResult, ValueList<TValue>>> propertyExpression,
            Expression<Func<TInput, ValueList<TValue>>> inputPropertyExpression)
            : base(propertyExpression, inputPropertyExpression)
        {
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public override void Apply(ITranslateBuilder<TResult, TInput, TSchema> builder)
        {
            var translator = new CopyValueListEntityPropertyTranslator<TResult, TValue, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo, InputPropertyInfo);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}