using BehavioralCriterias.Core.Ast;
using BehavioralCriterias.Core.Rules;
using ProductionRuleSystem.Core.Ast;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionRuleSystem.Core
{
    public interface IWorkingMemory
    {
        bool IsFact(Expression expression);

        int Count();

        Fact AddFact(ref Fact fact);

        IEnumerable<Fact> GetFacts(string variable);
    }
}
