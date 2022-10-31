using BehavioralCriterias.Core.Rules;
using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Rules;
using System;
using System.Collections.Generic;

namespace BehavioralCriterias.Rules
{
    public class RuleItem : Rule
    {
        private readonly string _name;
        private readonly string _description;
        private readonly RuleConditionGroup _conditions;
        private readonly RuleActionGroup _actions;

        private bool _isExecuted = false;

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

        public override bool IsExecuted => _isExecuted;

        public override bool Evaluate(IWorkingMemory memory)
        {
            // Evaluate if every specified condition match a fact
            foreach(var condition in _conditions.Conditions)
            {
                if (!memory.IsFact(condition)) return false;
            }
            return true;
        }

        public override IEnumerable<RuleActionResult> Execute(IWorkingMemory workingMemory)
        {
            if (_isExecuted) throw new Exception();
            _isExecuted = true;
            return _actions.Execute(workingMemory);
        }
    }
}
