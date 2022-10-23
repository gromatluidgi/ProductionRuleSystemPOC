using BehavioralCriterias.Core.Rules;
using ProductionRuleSystem.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralCriterias.Rules
{
    public class RuleItem : Rule
    {
        private readonly string _name;
        private readonly string _description;
        private readonly RuleConditionGroup _conditions;
        private readonly RuleActionGroup _actions;

        public RuleItem(string name, string description, RuleConditionGroup conditions, RuleActionGroup actions)
        {
            _name = name;
            _description = description;
            _conditions = conditions;
            _actions = actions;
        }

        public override string Name => _name;

        public override string Description => _description;

        public override RuleConditionGroup Conditions => _conditions;

        public override RuleActionGroup Actions => _actions;

        public override bool Evaluate(IWorkingMemory memory)
        {
            foreach(var condition in _conditions.Conditions)
            {
                if (!memory.IsFact(condition.Expression)) return false;
            }
            return true;
        }

        public override void Execute(IWorkingMemory memory)
        {
        }
    }
}
