﻿using BehavioralCriterias.Core.Ast;
using BehavioralCriterias.Core.Rules;
using System;

namespace ProductionRuleSystem.Conditions
{
    public class IssueCondition : RuleCondition
    {
        public IssueCondition(string variable, string value, string ope) : base(variable, value, ope)
        {
        }

        public override bool Evaluate(Expression condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));
            return MatchExpression(condition) == IntersectionType.INCLUDE;
        }
    }
}
