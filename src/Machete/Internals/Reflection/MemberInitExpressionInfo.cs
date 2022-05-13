namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;


    /// <summary>Analog of MemberInitExpression</summary>
    public class MemberInitExpressionInfo :
        ExpressionInfo
    {
        /// <inheritdoc />
        public override ExpressionType NodeType => ExpressionType.MemberInit;

        /// <inheritdoc />
        public override Type Type => ExpressionInfo.Type;

        /// <summary>New expression.</summary>
        public NewExpressionInfo NewExpressionInfo => ExpressionInfo as NewExpressionInfo;

        /// <summary>New expression.</summary>
        public readonly ExpressionInfo ExpressionInfo;

        /// <summary>Member assignments.</summary>
        public readonly MemberAssignmentInfo[] Bindings;

        /// <inheritdoc />
        public override Expression ToExpression() =>
            Expression.MemberInit(NewExpressionInfo.ToNewExpression(), 
                Bindings.Project(b => b.ToMemberAssignment()));

        /// <summary>Constructs from the new expression and member initialization list.</summary>
        public MemberInitExpressionInfo(NewExpressionInfo newExpressionInfo, MemberAssignmentInfo[] bindings)
            : this((ExpressionInfo)newExpressionInfo, bindings) { }

        /// <summary>Constructs from existing expression and member assignment list.</summary>
        public MemberInitExpressionInfo(ExpressionInfo expressionInfo, MemberAssignmentInfo[] bindings)
        {
            ExpressionInfo = expressionInfo;
            Bindings = bindings ?? Tools.Empty<MemberAssignmentInfo>();
        }
    }
}