using BehavioralCriterias.Core.Ast;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralCriterias.Core.Rules
{
    public abstract class RuleCondition
    {
        public abstract Expression Expression { get; }

        public abstract bool Evaluate(Expression fact);
    }
}
