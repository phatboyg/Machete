namespace Machete.Internals.Reflection
{
    using System.Linq.Expressions;
    using System.Reflection;


    /// <summary>MemberAssignment analog.</summary>
    public struct MemberAssignmentInfo
    {
        /// <summary>Member to assign to.</summary>
        public MemberInfo Member;

        /// <summary>Expression to assign</summary>
        public ExpressionInfo Expression;

        /// <summary>Converts back to MemberAssignment</summary>
        public MemberBinding ToMemberAssignment() =>
            System.Linq.Expressions.Expression.Bind(Member, Expression.ToExpression());

        /// <summary>Constructs out of member and expression to assign.</summary>
        public MemberAssignmentInfo(MemberInfo member, ExpressionInfo expression)
        {
            Member = member;
            Expression = expression;
        }
    }
}