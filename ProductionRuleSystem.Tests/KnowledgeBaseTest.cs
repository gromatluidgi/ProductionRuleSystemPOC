using BehavioralCriterias.Core.Rules;
using BehavioralCriterias.Rules;
using ProductionRuleSystem;
using ProductionRuleSystem.Core.Ast;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BehavioralCriterias.Tests
{
    public class KnowledgeBaseTest
    {
        [Fact]
        public void Ctor()
        {
            // Arrange
            var knowledgeBase = new KnowledgeBase();

            // Assert
            Assert.NotNull(knowledgeBase);
        }

        [Fact]
        public void AddRule()
        {
            // Arrange
            var knowledgeBase = new KnowledgeBase();
            var conditions = new RuleConditionGroup(new List<RuleCondition>());
            var actions = new RuleActionGroup(new List<RuleAction>());
            var rule = new RuleItem("Test", "Test", conditions, actions);

            // Act
            knowledgeBase.AddRule(rule);

            // Assert
            Assert.True(knowledgeBase.Rules.ToList().Count == 1);
        }
    }
}
