using BehavioralCriterias.Core.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionRuleSystem.Core
{
    public interface IKnowledgeBase
    {
        IEnumerable<Rule> Rules { get; }

        void AddRule(Rule rule);
    }
}
