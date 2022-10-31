using BehavioralCriterias.Core.Rules;
using ProductionRuleSystem.Core.Ast;
using System.Collections.Generic;

namespace ProductionRuleSystem.Core
{
    public interface IKnowledgeBase
    {
        IGrammar Grammar { get; }

        IEnumerable<Rule> GetRules();

        IEnumerable<Rule> GetUsedRules();

        void AddRule(Rule rule);
    }
}
