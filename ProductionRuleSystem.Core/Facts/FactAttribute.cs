using BehavioralCriterias.Core.Ast;
using ProductionRuleSystem.Core.Ast;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionRuleSystem.Core.Facts
{
    public class FactAttribute : Expression<object>
    {
        public FactAttribute(string type, object value) : base(type, value)
        {
        }


        public override ExpressionType Type => ExpressionType.FactAttribute;

        public override IntersectionType Intersect(Expression<object> rhs)
        {
            throw new NotImplementedException();
        }
    }
}
