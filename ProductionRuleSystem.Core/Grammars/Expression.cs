using ProductionRuleSystem.Core.Ast;
using System;

namespace BehavioralCriterias.Core.Ast
{
    public abstract class Expression<T>
    {
        private readonly string _variable;
        private readonly T _value;
        private readonly string _operator = "";

        protected Expression(string variable, T value)
        {
            _variable = variable;
            _value = value;
        }

        protected Expression(string variable, T value, string ope)
        {
            _variable = variable;
            _value = value;
            _operator = ope;
        }

        public string Variable => _variable;
        public T Value => _value;
        public string Operator => _operator;
        
        public abstract ExpressionType Type { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rhs">The tested fact.</param>
        /// <returns></returns>
        public virtual IntersectionType MatchExpression(Expression<T> rhs)
        {
            // Ensure that the given expression type match the current expression
            // If not, the evaluation can't be performed
            if (Variable != rhs.Variable)
            {
                return IntersectionType.UNKNOWN;
            }
            return Intersect(rhs);
        }

        public abstract IntersectionType Intersect(Expression<T> rhs);
    }
}
