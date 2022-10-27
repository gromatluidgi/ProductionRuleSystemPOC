using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralCriterias.Core.Rules
{
    public sealed class RuleActionGroup
    {
        private readonly List<RuleAction> _actions;

        public RuleActionGroup(List<RuleAction> conditions)
        {
            _actions = conditions;
        }

        public IEnumerable<RuleAction> Conditions => _actions;

        public void AddAction(RuleAction ruleCondition)
        {
            _actions.Add(ruleCondition);
        }

        public IEnumerable<RuleActionResult> Execute(IWorkingMemory workingMemory)
        {
            List<RuleActionResult> result = new List<RuleActionResult>();
            foreach (var ruleAction in _actions)
            {
                result.Add(ruleAction.Execute(workingMemory));
            }
            return result;
        }
    }
}
