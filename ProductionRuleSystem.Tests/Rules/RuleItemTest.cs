using BehavioralCriterias.Domain;
using BehavioralCriterias.Rules;
using Xunit;

namespace ProductionRuleSystem.Tests.Rules
{
    public class RuleItemTest : BaseTestClass
    {
        [Fact]
        public void Evaluate()
        {
            // Arrange
            var issue = new Issue(0, "open");
            var workingMemory = new WorkingMemory(new FactFactory());
            workingMemory.AddFact(issue);

            var rule = new RuleItem("test", "test", MockRuleConditionGroup(), MockRuleActionGroup());

            // Act
            var result = rule.Evaluate(workingMemory);

            // Assert
            Assert.True(result);
        }
    }
}
