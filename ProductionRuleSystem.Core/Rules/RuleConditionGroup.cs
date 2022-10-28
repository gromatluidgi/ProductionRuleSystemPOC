using BehavioralCriterias.Core.Ast;
using System.Collections.Generic;

namespace BehavioralCriterias.Core.Rules
{
    public sealed class RuleConditionGroup
    {
        private readonly List<RuleCondition> _conditions;

        public RuleConditionGroup(List<RuleCondition> conditions)
        {
            _conditions = conditions;
        }

        public IEnumerable<RuleCondition> Conditions => _conditions;

        public void AddCondition(RuleCondition ruleCondition)
        {
            _conditions.Add(ruleCondition);
        }

        public bool Match(Expression fact)
        {
            foreach(var ruleCondition in _conditions)
            {
                if (!ruleCondition.Evaluate(fact)) return false;
            }

            return true;
        }
    }
}
