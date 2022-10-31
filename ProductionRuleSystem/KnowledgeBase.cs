using BehavioralCriterias.Core.Rules;
using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Ast;
using System.Collections.Generic;

namespace ProductionRuleSystem
{
    public sealed class KnowledgeBase : IKnowledgeBase
    {
        private readonly List<Rule> _rules;
        private readonly List<Rule> _usedRules;
        private readonly IGrammar _grammer;

        public KnowledgeBase()
        {
            _rules = new List<Rule>();
            _usedRules = new List<Rule>();
        }

        public IGrammar Grammar => _grammer;

        public void AddRule(Rule rule)
        {
            _rules.Add(rule);
        }

        public IEnumerable<Rule> GetRules()
        {
            return _rules;
        }

        public IEnumerable<Rule> GetUsedRules()
        {
            return _usedRules;
        }

        public void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
