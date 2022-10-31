using BehavioralCriterias.Core.Ast;
using BehavioralCriterias.Core.Rules;
using System;

namespace ProductionRuleSystem.Conditions
{
    public class CustomerCondition : RuleCondition
    {
        public CustomerCondition(string variable, string value, string ope) : base(variable, value, ope)
        {
        }

        public override bool Evaluate(Expression<object> condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));
            return MatchExpression(condition) == IntersectionType.INCLUDE;
        }

        public override IntersectionType Intersect(Expression<object> rhs)
        {
            throw new NotImplementedException();
        }
    }
}
