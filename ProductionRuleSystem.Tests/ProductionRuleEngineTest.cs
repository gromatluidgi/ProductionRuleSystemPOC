using BehavioralCriterias;
using BehavioralCriterias.Core.Rules;
using BehavioralCriterias.Domain;
using BehavioralCriterias.Rules;
using ProductionRuleSystem.Actions.Issues;
using ProductionRuleSystem.Actions.Transactions;
using ProductionRuleSystem.Conditions;
using ProductionRuleSystem.Core.Ast;
using ProductionRuleSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProductionRuleSystem.Tests
{
    public class ProductionRuleEngineTest : BaseTestClass
    {
        [Fact]
        public void ForwardChaining()
        {
            // Arrange
            var fact = new Fact("ISSUE.STATE", "open", new Issue("open"));
            var workingMemory = new WorkingMemory();
            workingMemory.AddFact(ref fact);
            var rule = new RuleItem("test", "test", MockRuleConditionGroup(), MockRuleActionGroup());
            var knowledgeBase = new KnowledgeBase();
            knowledgeBase.AddRule(rule);
            var engine = new ProductionRuleEngine(knowledgeBase, workingMemory);

            // Act
            engine.ForwardChaining();

            // Assert
            Assert.True(((Issue)fact.Context).State.Equals("infered"));
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


            var workingMemory = new WorkingMemory();
            workingMemory.AddFact(ref f_customer1);
            workingMemory.AddFact(ref c1_t1);
            workingMemory.AddFact(ref c1_t2);


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
