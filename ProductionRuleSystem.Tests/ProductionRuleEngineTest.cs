using BehavioralCriterias;
using BehavioralCriterias.Core.Rules;
using BehavioralCriterias.Domain;
using BehavioralCriterias.Rules;
using ProductionRuleSystem.Actions.Transactions;
using ProductionRuleSystem.Conditions;
using ProductionRuleSystem.Core.Ast;
using ProductionRuleSystem.Domain;
using System.Collections.Generic;
using Xunit;

namespace ProductionRuleSystem.Tests
{
    public class ProductionRuleEngineTest : BaseTestClass
    {
        [Fact]
        public void ForwardChaining()
        {
            // Arrange
            var issue = new Issue("open");
            var factFactory = new FactFactory();
            var workingMemory = new WorkingMemory(factFactory);
            workingMemory.AddFact(issue);

            var rule = new RuleItem("test", "test", MockRuleConditionGroup(), MockRuleActionGroup());
            var knowledgeBase = new KnowledgeBase();
            knowledgeBase.AddRule(rule);

            var engine = new ProductionRuleEngine(knowledgeBase, workingMemory);

            // Act
            engine.ForwardChaining();

            // Assert
            Assert.True(issue.State.Equals("infered"));
        }

        [Fact]
        public void ForwardChaining_Mixed()
        {
            // Arrange
            var customer1 = new Customer("John", 100);

            var transaction1 = new Transaction(customer1, 1000);
            var transaction2 = new Transaction(customer1, 20);


            var f_customer1 = new Fact("CUSTOMER.NAME", "John", customer1);
            var c1_t1 = new Fact("TRANSAC.STATE", "PENDING", transaction1);
            var c1_t2 = new Fact("TRANSAC.STATE", "PENDING", transaction2);

            var factFactory = new FactFactory();
            var workingMemory = new WorkingMemory(factFactory);
            workingMemory.AddFact(customer1);
            workingMemory.AddFact(transaction1);
            workingMemory.AddFact(transaction2);


            var conditions = new RuleConditionGroup(new List<RuleCondition>()
            {
                new CustomerCondition("CUSTOMER.NAME", "John", "=")
            });

            var actions = new RuleActionGroup(new List<RuleAction>()
            {
                new ChangeTransactionState("TRANSAC.STATE", "APPROVED", "=")
            });

            var rule = new RuleItem("test", "test", conditions, actions);
            var knowledgeBase = new KnowledgeBase();
            knowledgeBase.AddRule(rule);
            var engine = new ProductionRuleEngine(knowledgeBase, workingMemory);

            // Act
            engine.ForwardChaining();

            // Assert
            Assert.NotNull(workingMemory);
        }
    }
}
