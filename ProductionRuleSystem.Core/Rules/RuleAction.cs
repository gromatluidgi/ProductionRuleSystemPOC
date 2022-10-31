using BehavioralCriterias.Core.Ast;
using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Ast;
using ProductionRuleSystem.Core.Facts;
using ProductionRuleSystem.Core.Rules;
using System.Collections.Generic;

namespace BehavioralCriterias.Core.Rules
{
    public abstract class RuleAction : Expression<object>
    {
        protected RuleAction(string variable, string value, IEnumerable<FactAttribute> properties) : base(variable, value)
        {
        }

        public abstract IEnumerable<RuleActionResult> Execute(IWorkingMemory workingMemory);

        public override ExpressionType Type => ExpressionType.Action;

        public override IntersectionType Intersect(Expression<object> rhs)
        {
            throw new System.NotImplementedException("Not supported by Action expression.");
        }

    }
}
