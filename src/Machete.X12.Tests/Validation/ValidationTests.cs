namespace Machete.X12.Tests.Validation
{
    using System;
    using System.Collections.Concurrent;
    using System.Linq.Expressions;
    using Internals.Extensions;
    using Machete.Values;
    using NUnit.Framework;
    using X12Schema.V5010;


    [TestFixture]
    public class ValidationTests
    {
        [Test]
        public void Test()
        {
            IValidator validator = new Validator();
            IValidationRules rules = new ValidationRules();
            rules.Add(new FakeValidationRule());
            IValidationReport report = validator.Validate(rules);

            foreach (var result in report)
            {
                result.IsValid()
            }
        }
        
        class FakeValidationRule :
            X12SegmentValidator<NM1, X12Entity>
        {
            public FakeValidationRule()
            {
                Validate(x => x.EntityIdentifierCode, x => x.Is("IL"));
            }
        }
    }


    public interface IValidationRules<TSegment, TSchema>
        where TSchema : X12Entity
        where TSegment : TSchema
    {
        void Add(ISegmentValidator<TSegment, TSchema> fakeValidationRule);
    }


    public class ValidationRules :
        IValidationRules<>
    {
    }


    public static class ValidationExtensions
    {
        public static Value<T> Is<TSchema, T>(this ValidationContext<TSchema> context, T value)
        {
            return new ConstantValue<T>(value);
        }
    }
    
    public delegate Value<T> ValidationProvider<TSchema, out T>(ValidationContext<TSchema> context)
        where TSchema : Entity;


    public interface ValidationContext<T>
    {
    }


    class X12SegmentValidator<TSegment, TSchema> :
        SegmentValidator<TSegment, TSchema>
        where TSchema : X12Entity
        where TSegment : TSchema, X12Segment
    {
    }


    class SegmentValidator<TResult, TSchema> :
        ISegmentValidator<TResult, TSchema>
        where TSchema : Entity
        where TResult : TSchema
    {
        readonly ConcurrentBag<IValidatorResult> _results;

        public SegmentValidator()
        {
            _results = new ConcurrentBag<IValidatorResult>();
        }

        public void Validate<T>(Expression<Func<TResult, Value<T>>> propertyExpression, ValidationProvider<TSchema, T> valueProvider)
        {
            var resultPropertyInfo = propertyExpression.GetPropertyInfo();
            if (resultPropertyInfo == null)
                _results.Add(new ValidatorResult("Property not found", $"{TypeCache<TResult>.ShortName}.{resultPropertyInfo?.Name}"));

            if (resultPropertyInfo != null)
            {
                var propertyInfo = typeof(TResult).GetProperty(resultPropertyInfo.Name);
                if (propertyInfo == null)
                    _results.Add(new ValidatorResult("Property not found", $"{TypeCache<TResult>.ShortName}.{resultPropertyInfo?.Name}"));
                else
                {
                    if (propertyInfo.PropertyType != resultPropertyInfo.PropertyType)
                        _results.Add(new ValidatorResult("Property type mismatch",
                            $"{TypeCache<TResult>.ShortName}.{resultPropertyInfo?.Name} ({TypeCache.GetShortName(resultPropertyInfo.PropertyType)})"));
                }
            }
            // var resultValue = valueProvider(context) ?? Value.Missing<TValue>();

            // foreach (var result in Validate())
            //     yield return result;
        }

        public ConcurrentBag<IValidatorResult> Results => _results;
    }


    public interface ISegmentValidator<TResult, TSchema>
        where TSchema : Entity
        where TResult : TSchema
    {
        ConcurrentBag<IValidatorResult> Results { get; }

        void Validate<T>(Expression<Func<TResult, Value<T>>> propertyExpression, ValidationProvider<TSchema, T> valueProvider);
    }


    interface IValidatorResult
    {
    }


    class ValidatorResult :
        IValidatorResult
    {
        public ValidatorResult(string propertyTypeMismatch, string s)
        {
        }
    }
}