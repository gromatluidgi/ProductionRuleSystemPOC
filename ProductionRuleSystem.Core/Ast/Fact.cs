using BehavioralCriterias.Core.Ast;
using System;
using System.Collections.Generic;

namespace ProductionRuleSystem.Core.Ast
{
    public sealed class Fact : Expression
    {
        private readonly object _context;

        public Fact(string variable, string value, object context, string ope = "=") : base(variable, value, ope)
        {
            _context = context;
        }

        public object Context => _context;

        public override IntersectionType Intersect(Expression rhs)
        {

            if (Operator.Equals("="))
            {
                if (Value.Equals(rhs.Value))
                {
                    return IntersectionType.INCLUDE;
                } else
                {
                    return IntersectionType.MUTUALLY_EXCLUDE;
                }
            }
            return IntersectionType.UNKNOWN;
        }

    }

    public class FactComparer : IEqualityComparer<Fact>
    {
        public bool Equals(Fact x, Fact y)
        {
            return x.Variable == y.Variable && x.Value == y.Value && x.Context == y.Context;
        }

        public int GetHashCode(Fact obj)
        {
            return HashCode.Combine(obj.Variable, obj.Value, obj.Context);
        }
    }
}
