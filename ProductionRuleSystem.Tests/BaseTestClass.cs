using BehavioralCriterias.Core.Rules;
using ProductionRuleSystem.Actions.Issues;
using ProductionRuleSystem.Conditions;
using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Facts;
using System.Collections.Generic;

namespace ProductionRuleSystem.Tests
{
    public abstract class BaseTestClass
    {
        protected virtual IWorkingMemory MockWorkingMemory()
        {
            return new WorkingMemory(new FactFactory());
        }

        protected virtual IKnowledgeBase MockKnowledgeBase()
        {
            return new KnowledgeBase();
        }

        protected virtual RuleConditionGroup MockRuleConditionGroup()
        {
            return new RuleConditionGroup(new List<RuleCondition>()
            {
                new IssueCondition("issue", "open", "=")
            });
        }

        protected virtual RuleActionGroup MockRuleActionGroup()
        {
            return new RuleActionGroup(new List<RuleAction>()
            {
                new ChangeIssueStateAction(string.Empty, new List<FactAttribute>()
                {
                    new FactAttribute("state", "close")
                })
            });
        }
    }
}
