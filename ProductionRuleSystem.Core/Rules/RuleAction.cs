using BehavioralCriterias.Core.Ast;
using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralCriterias.Core.Rules
{
    public abstract class RuleAction : Expression
    {
        protected RuleAction(string variable, string value) : base(variable, value)
        {
        }
        protected RuleAction(string variable, string value, string ope) : base(variable, value, ope)
        {
        }

        public abstract RuleActionResult Execute(IWorkingMemory workingMemory);
    }
}
