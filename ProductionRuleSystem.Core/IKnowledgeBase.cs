using BehavioralCriterias.Core.Rules;
using System.Collections.Generic;

namespace ProductionRuleSystem.Core
{
    public interface IKnowledgeBase
    {
        IEnumerable<Rule> Rules { get; }

        void AddRule(Rule rule);
    }
}
