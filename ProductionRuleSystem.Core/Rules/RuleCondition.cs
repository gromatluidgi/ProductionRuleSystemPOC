using BehavioralCriterias.Core.Ast;
using ProductionRuleSystem.Core.Ast;

namespace BehavioralCriterias.Core.Rules
{
    public abstract class RuleCondition : Expression<object>
    {
        protected RuleCondition(string variable, string value, string ope) : base(variable, value, ope)
        {
        }

        public abstract bool Evaluate(Expression<object> condition);

        public override ExpressionType Type => ExpressionType.Condition;
    }
}
