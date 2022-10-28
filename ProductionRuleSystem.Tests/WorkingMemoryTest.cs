using ProductionRuleSystem.Core.Ast;
using Xunit;

namespace ProductionRuleSystem.Tests
{
    public class WorkingMemoryTest
    {
        [Fact]
        public void AddFact()
        {
            // Arrange
            var factFactory = new FactFactory();
            var workingMemory = new WorkingMemory(factFactory);
            var fact = new Fact("Issue.State", "open", null);

            // Act
            workingMemory.AddFact(fact);

            // Assert
            Assert.True(workingMemory.Count() == 1);
        }

        [Fact]
        public void AddFact_Check_Uniqueness()
        {
            // Arrange
            var factFactory = new FactFactory();
            var workingMemory = new WorkingMemory(factFactory);
            var fact = new Fact("Issue.State", "open", null);
            var fact2 = new Fact("Issue.State", "open", null);

            // Act
            workingMemory.AddFact(fact);
            workingMemory.AddFact(fact2);

            // Assert
            Assert.True(workingMemory.Count() == 1);
        }
    }
}
