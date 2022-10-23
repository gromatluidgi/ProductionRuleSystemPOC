using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BehavioralCriterias.Core.Ast
{
    public class Expression
    {
        public Expression()
        {

        }

        public string Variable { get; }
        public string Value { get; }
        public string Operator { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rhs">The tested fact.</param>
        /// <returns></returns>
        public virtual IntersectionType MatchExpression(Expression rhs)
        {
            if (Variable != rhs.Variable)
            {
                return IntersectionType.UNKNOWN;
            }
            return Intersect(rhs);
        }

        public virtual IntersectionType Intersect(Expression rhs)
        {
            throw new NotImplementedException();
        }
    }
}
