using BehavioralCriterias.Core.Ast;
using ProductionRuleSystem.Core.Facts;
using Xunit;

namespace ProductionRuleSystem.Tests.Ast
{
    public class FactTest
    {
        [Xunit.Fact]
        public void Intersect_Returns_Include()
        {
            // Arrange
            var lhs = new Fact("Issue.State", "open", null);
            var rhs = new Fact("Issue.State", "open", null);

            // Act
            var result = lhs.Intersect(rhs);

            // Assert
            Assert.True(result.Equals(IntersectionType.INCLUDE));
        }

        [Xunit.Fact]
        public void Intersect_Returns_Exclude()
        {
            // Arrange
            var lhs = new Fact("Issue.State", "open", null);
            var rhs = new Fact("Issue.State", "close", null);

            // Act
            var result = lhs.Intersect(rhs);

            // Assert
            Assert.True(result.Equals(IntersectionType.MUTUALLY_EXCLUDE));
        }

        [Xunit.Fact]
        public void Intersect_Returns_Unkonwn()
        {
            // Arrange
            var lhs = new Fact("Issue.State", "open", null);
            var rhs = new Fact("Issue.Mock", "0", null);

            // Act
            var result = lhs.Intersect(rhs);

            // Assert
            Assert.True(result.Equals(IntersectionType.UNKNOWN));
        }
    }
}
