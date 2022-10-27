using BehavioralCriterias.Domain;
using ProductionRuleSystem.Core.Ast;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionRuleSystem
{
    public static class FactFactory
    {
        public static Fact FromIssue(Issue issue)
        {
            return new Fact("ISSUE.STATE", issue.State, issue);
        }

    }
}
