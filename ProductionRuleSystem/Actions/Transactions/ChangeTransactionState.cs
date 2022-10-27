using BehavioralCriterias.Core.Rules;
using ProductionRuleSystem.Core.Rules;
using ProductionRuleSystem.Core;
using System;
using System.Collections.Generic;
using System.Text;
using ProductionRuleSystem.Domain;
using System.Linq;
using ProductionRuleSystem.Core.Ast;

namespace ProductionRuleSystem.Actions.Transactions
{
    public class ChangeTransactionState : RuleAction
    {
        public ChangeTransactionState(string variable, string value, string ope) : base(variable, value, ope)
        {
        }

        public override RuleActionResult Execute(IWorkingMemory workingMemory)
        {
            List<Fact> transactions = (List<Fact>)workingMemory.GetFacts(Variable);
            foreach(var transaction in transactions)
            {
                ((Transaction)transaction.Context).State = (TransactionState)Enum.Parse(typeof(TransactionState), Value);
            }
            return new RuleActionResult(transactions);
        }
    }
}
