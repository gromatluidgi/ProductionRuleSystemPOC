using BehavioralCriterias.Core.Ast;

namespace BehavioralCriterias.Core.Rules
{
    public abstract class RuleCondition : Expression
    {
        protected RuleCondition(string variable, string value, string ope) : base(variable, value, ope)
        {
        }

        public abstract bool Evaluate(Expression condition);
    }
}
