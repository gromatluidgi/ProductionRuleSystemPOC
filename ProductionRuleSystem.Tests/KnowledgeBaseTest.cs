using ProductionRuleSystem;
using System;
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

        }
    }
}
