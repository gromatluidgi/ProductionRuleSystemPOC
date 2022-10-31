using BehavioralCriterias.Domain;
using Xunit;

namespace ProductionRuleSystem.Tests
{
    public class WorkingMemoryTest
    {
        [Fact]
        public void AddFact()
        {
            // Arrange
            var issue = new Issue(0, "open");
            var factFactory = new FactFactory();
            var workingMemory = new WorkingMemory(factFactory);

            // Act
            workingMemory.AddFact(issue);

            // Assert
            Assert.True(workingMemory.Count() == 1);
        }

        [Fact]
        public void AddFact_Check_Uniqueness()
        {
            // Arrange
            var factFactory = new FactFactory();
            var workingMemory = new WorkingMemory(factFactory);
            var issue = new Issue(0, "open");


            // Act
            workingMemory.AddFact(issue);
            workingMemory.AddFact(issue);

            // Assert
            Assert.True(workingMemory.Count() == 1);
        }
    }
}
