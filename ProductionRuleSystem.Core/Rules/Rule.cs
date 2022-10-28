using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Rules;
using System.Collections.Generic;

namespace BehavioralCriterias.Core.Rules
{
    public abstract class Rule
    {
        public abstract string Name { get; }
        public abstract string Description { get; }

        /// <summary>
        /// Antecedents
        /// </summary>
        public abstract RuleConditionGroup Conditions { get; }
        
        /// <summary>
        /// Consequents
        /// </summary>
        public abstract RuleActionGroup Actions { get; }

        public abstract bool Evaluate(IWorkingMemory memory);
        public abstract IEnumerable<RuleActionResult> Execute(IWorkingMemory workingMemory);
    }
}
