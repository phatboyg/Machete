namespace Machete.Layouts
{
    using System;
    using System.Linq.Expressions;


    /// <summary>
    /// Creates a layout using the dynamic implmentation type
    /// </summary>
    /// <typeparam name="TLayout"></typeparam>
    public class DynamicLayoutFactory<TLayout> :
        ILayoutFactory<TLayout>
        where TLayout : Layout
    {
        readonly Func<TLayout> _new;

        public DynamicLayoutFactory(Type implementationType)
        {
            _new = CompileNewMethod(implementationType);
        }

        public TLayout Create()
        {
            return _new();
        }

        public Type EntityType => typeof(TLayout);

        static Func<TLayout> CompileNewMethod(Type implementationType)
        {
            NewExpression newExpression = Expression.New(implementationType);
            Expression<Func<TLayout>> lambda = Expression.Lambda<Func<TLayout>>(newExpression);

            return lambda.Compile();
        }
    }
}