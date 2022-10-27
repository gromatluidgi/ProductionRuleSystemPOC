using BehavioralCriterias.Core.Ast;
using BehavioralCriterias.Core.Rules;
using BehavioralCriterias.Domain;
using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductionRuleSystem
{
    public class WorkingMemory : IWorkingMemory
    {
        private readonly HashSet<Fact> _facts;

        public WorkingMemory()
        {
            _facts = new HashSet<Fact>(new FactComparer());
        }

        public Fact AddFact(ref Fact fact)
        {
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
