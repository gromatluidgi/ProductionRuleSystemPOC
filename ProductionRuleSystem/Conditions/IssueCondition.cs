using BehavioralCriterias.Core.Ast;
using BehavioralCriterias.Core.Rules;
using BehavioralCriterias.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionRuleSystem.Conditions
{
    internal class IssueCondition : RuleCondition
    {
        private readonly Expression _expression;

        public IssueCondition(Expression expression)
        {
            _expression = expression;
        }

        public override Expression Expression => _expression;

        public override bool Evaluate(Expression fact)
        {
            if (fact == null) throw new ArgumentNullException(nameof(fact));
            return _expression.MatchExpression(fact) == IntersectionType.INCLUDE;
        }
    }
}
