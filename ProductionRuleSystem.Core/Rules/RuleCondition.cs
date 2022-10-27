using BehavioralCriterias.Core.Ast;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralCriterias.Core.Rules
{
    public abstract class RuleCondition : Expression
    {
        protected RuleCondition(string variable, string value, string ope) : base(variable, value, ope)
        {
        }

        public abstract bool Evaluate(Expression condition);
    }
}
