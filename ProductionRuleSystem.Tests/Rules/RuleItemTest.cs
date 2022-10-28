﻿using BehavioralCriterias.Domain;
using BehavioralCriterias.Rules;
using ProductionRuleSystem.Core.Ast;
using Xunit;

namespace ProductionRuleSystem.Tests.Rules
{
    public class RuleItemTest : BaseTestClass
    {
        [Fact]
        public void Evaluate()
        {
            // Arrange
            var fact = new Fact("ISSUE.STATE", "open", new Issue("open"));

            var workingMemory = new WorkingMemory(new FactFactory());
            workingMemory.AddFact(fact);

            var rule = new RuleItem("test", "test", MockRuleConditionGroup(), MockRuleActionGroup());

            // Act
            var result = rule.Evaluate(workingMemory);

            // Assert
            Assert.True(result);
        }
    }
}
