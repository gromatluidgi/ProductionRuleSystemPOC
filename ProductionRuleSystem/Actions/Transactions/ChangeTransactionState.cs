using BehavioralCriterias.Core.Rules;
using ProductionRuleSystem.Core.Rules;
using ProductionRuleSystem.Core;
using System;
using System.Collections.Generic;
using ProductionRuleSystem.Domain;
using BehavioralCriterias.Core.Ast;
using ProductionRuleSystem.Core.Facts;

namespace ProductionRuleSystem.Actions.Transactions
{
    public class ChangeTransactionState : RuleAction
    {
        public ChangeTransactionState(string variable, string value, IEnumerable<FactAttribute> properties) : base(variable, value, properties)
        {
        }

        //public override RuleActionResult Execute(IWorkingMemory workingMemory)
        //{
        //    List<Fact> transactions = (List<Fact>)workingMemory.GetFacts(Variable);
        //    foreach(var transaction in transactions)
        //    {
        //        ((Transaction)transaction.Context).State = (TransactionState)Enum.Parse(typeof(TransactionState), Value);
        //    }
        //    return new RuleActionResult(transactions);
        //}

        public override IEnumerable<RuleActionResult> Execute(IWorkingMemory workingMemory)
        {
            throw new NotImplementedException();
        }

        public override IntersectionType Intersect(Expression<object> rhs)
        {
            throw new NotImplementedException();
        }
    }
}
