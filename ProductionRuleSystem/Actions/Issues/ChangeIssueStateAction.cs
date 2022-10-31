using BehavioralCriterias.Core.Ast;
using BehavioralCriterias.Core.Rules;
using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Facts;
using ProductionRuleSystem.Core.Rules;
using System.Collections.Generic;
using System.Linq;

namespace ProductionRuleSystem.Actions.Issues
{
    /// <summary>
    /// When 
    /// </summary>
    public class ChangeIssueStateAction : RuleAction
    {
        private readonly List<FactAttribute> _properties;

        public ChangeIssueStateAction(
            string issueId,
            IEnumerable<FactAttribute> properties) : base("Issue", issueId, properties)
        {
            _properties = properties.ToList();
        }

        public override IEnumerable<RuleActionResult> Execute(IWorkingMemory workingMemory)
        {
            if (string.IsNullOrEmpty((string)Value))
            {
                return HandleManyFacts(workingMemory);
            }
            return HandleSingleFact(workingMemory);
        }

        protected IEnumerable<RuleActionResult> HandleManyFacts(IWorkingMemory workingMemory)
        {
            var facts = workingMemory.GetFacts(Variable);
            var inferedFacts = new List<RuleActionResult>();
            var newState = _properties.First(p => p.Type.Equals("state"));

            foreach (var fact in facts)
            {
                if (fact.GetProperty("state") != newState)
                {
                    fact.SetProperty("state", newState);
                    inferedFacts.Add(new RuleActionResult(fact, true));
                }
            }
            return inferedFacts;
        }

        protected IEnumerable<RuleActionResult> HandleSingleFact(IWorkingMemory workingMemory)
        {
            bool changed = false;
            var fact = workingMemory.GetFact(Variable, Value);
            var newState = _properties.First(p => p.Type.Equals("state"));
            if (fact.GetProperty("state") != newState)
            {
                fact.SetProperty("state", newState);
                changed = true;
            }

            return new List<RuleActionResult>{ new RuleActionResult(fact, changed) };
        }
    }
}