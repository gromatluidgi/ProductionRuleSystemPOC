using BehavioralCriterias.Core.Ast;
using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Facts;
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

        public void AddFact<T>(T input) where T : class
        {
            _facts.Add(_factFactory.From(input));
        }

        public int Count()
        {
            return _facts.Count;
        }

        public Fact GetFact(string variable, object value)
        {
            return _facts.FirstOrDefault(f => f.Variable.Equals(variable) && f.Value.Equals(value));
        }

        public IEnumerable<Fact> GetFacts(string variable)
        {
            return _facts.Where(f => f.Variable.Equals(variable)).ToList();
        }

        // Check if the expression match a fact
        public bool IsFact(Expression<object> expression)
        {
            foreach(Fact fact in _facts)
            {
                if (expression.MatchExpression(fact) == IntersectionType.INCLUDE)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
