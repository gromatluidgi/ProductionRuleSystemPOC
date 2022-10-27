using BehavioralCriterias.Core.Rules;
using ProductionRuleSystem.Actions.Issues;
using ProductionRuleSystem.Conditions;
using ProductionRuleSystem.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionRuleSystem.Tests
{
    public abstract class BaseTestClass
    {
        protected virtual IWorkingMemory MockWorkingMemory()
        {
            return new WorkingMemory();
        }

        protected virtual IKnowledgeBase MockKnowledgeBase()
        {
            return new KnowledgeBase();
        }

        protected virtual RuleConditionGroup MockRuleConditionGroup()
        {
            return new RuleConditionGroup(new List<RuleCondition>()
            {
                new IssueCondition("ISSUE.STATE", "open", "=")
            });
        }

        protected virtual RuleActionGroup MockRuleActionGroup()
        {
            return new RuleActionGroup(new List<RuleAction>()
            {
                new ChangeIssueStateAction("ISSUE.STATE", "infered")
            });
        }
    }
}
