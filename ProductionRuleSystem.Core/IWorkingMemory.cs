using BehavioralCriterias.Core.Ast;
using ProductionRuleSystem.Core.Ast;
using System.Collections.Generic;

namespace ProductionRuleSystem.Core
{
    public interface IWorkingMemory
    {
        bool IsFact(Expression expression);

        int Count();

        Fact AddFact<T>(T input);

        IEnumerable<Fact> GetFacts(string variable);
    }
}
