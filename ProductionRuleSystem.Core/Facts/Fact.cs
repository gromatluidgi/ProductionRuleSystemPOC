using BehavioralCriterias.Core.Ast;
using ProductionRuleSystem.Core.Ast;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductionRuleSystem.Core.Facts
{
    public sealed class Fact : Expression<object>
    {
        private readonly List<FactAttribute> _properties;

        public override ExpressionType Type => ExpressionType.Fact;

        public Fact(string name, string id, IEnumerable<FactAttribute> properties) : base(name, id)
        {
            _properties = properties.ToList();
        }

        public override IntersectionType Intersect(Expression<object> rhs)
        {

            if (Operator.Equals("="))
            {
                if (Value.Equals(rhs.Value))
                {
                    return IntersectionType.INCLUDE;
                }
                return IntersectionType.MUTUALLY_EXCLUDE;
            }
            return IntersectionType.UNKNOWN;
        }

        public FactAttribute GetProperty(string type)
        {
            return _properties.FirstOrDefault(p => p.Type.Equals(type));
        }

        public void SetProperty(string type, object value)
        {
            _properties.Remove(GetProperty(type));
            _properties.Add(new FactAttribute(type, value));
        }
    }

    public class FactComparer : IEqualityComparer<Fact>
    {
        public bool Equals(Fact x, Fact y)
        {
            return x.Variable == y.Variable && x.Value == y.Value;
        }

        public int GetHashCode(Fact obj)
        {
            return HashCode.Combine(obj.Variable, obj.Value);
        }
    }
}
