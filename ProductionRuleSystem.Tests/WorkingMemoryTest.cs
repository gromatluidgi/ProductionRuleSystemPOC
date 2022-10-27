using ProductionRuleSystem.Core.Ast;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProductionRuleSystem.Tests
{
    public class WorkingMemoryTest
    {
        [Fact]
        public void AddFact()
        {
            // Arrange
            var workingMemory = new WorkingMemory();
            var fact = new Fact("Issue.State", "open", null);

            // Act
            workingMemory.AddFact(ref fact);

            // Assert
            Assert.True(workingMemory.Count() == 1);
        }

        [Fact]
        public void AddFact_Check_Uniqueness()
        {
            // Arrange
            var workingMemory = new WorkingMemory();
            var fact = new Fact("Issue.State", "open", null);
            var fact2 = new Fact("Issue.State", "open", null);

            // Act
            workingMemory.AddFact(ref fact);
            workingMemory.AddFact(ref fact2);

            // Assert
            Assert.True(workingMemory.Count() == 1);
        }

        public void IsFact()
        {

        }
    }
}
