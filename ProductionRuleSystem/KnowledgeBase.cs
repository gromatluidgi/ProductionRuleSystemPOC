using BehavioralCriterias.Core.Rules;
using ProductionRuleSystem.Core;
using System.Collections.Generic;

namespace ProductionRuleSystem
{
    public sealed class KnowledgeBase : IKnowledgeBase
    {
        private readonly List<Rule> _rules;

        public KnowledgeBase()
        {
            _rules = new List<Rule>();
        }

        public IEnumerable<Rule> Rules => _rules;

        public void AddRule(Rule rule)
        {
            _rules.Add(rule);
        }
    }
}
