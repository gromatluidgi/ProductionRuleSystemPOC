using BehavioralCriterias.Core.Ast;
using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Ast;
using System.Collections.Generic;
using System.Linq;

namespace ProductionRuleSystem
{
    public class WorkingMemory : IWorkingMemory
    {
        private readonly HashSet<Fact> _facts;
        private readonly IFactFactory _factFactory;

        public WorkingMemory(IFactFactory factFactory)
        {
            _factFactory = factFactory;
            _facts = new HashSet<Fact>(new FactComparer());
        }

        public Fact AddFact<T>(T input)
        {
            var fact = _factFactory.From(input);
            _facts.Add(fact);
            return fact;
        }

        public int Count()
        {
            return _facts.Count;
        }

        public IEnumerable<Fact> GetFacts(string variable)
        {
            return _facts.Where(f => f.Variable.Equals(variable)).ToList();
        }

        // Check if the expression match a fact
        public bool IsFact(Expression expression)
        {
            foreach(Fact fact in _facts)
            {
                if (fact.MatchExpression(expression) == IntersectionType.INCLUDE)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
