using BehavioralCriterias.Core.Ast;
using ProductionRuleSystem.Core.Facts;
using System.Collections.Generic;

namespace ProductionRuleSystem.Core
{
    public interface IWorkingMemory
    {
        bool IsFact(Expression<object> expression);

        int Count();

        void AddFact<T>(T input) where T: class;

        IEnumerable<Fact> GetFacts(string variable);

        Fact GetFact(string variable, object value);
    }
}
