using System;

namespace BehavioralCriterias.Core.Ast
{
    public abstract class Expression
    {
        private readonly string _variable;
        private readonly string _value;
        private readonly string _operator = "";

        protected Expression(string variable, string value)
        {
            _variable = variable;
            _value = value;
        }

        protected Expression(string variable, string value, string ope)
        {
            _variable = variable;
            _value = value;
            _operator = ope;
        }

        public string Variable => _variable;
        public string Value => _value;
        public string Operator => _operator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rhs">The tested fact.</param>
        /// <returns></returns>
        public virtual IntersectionType MatchExpression(Expression rhs)
        {
            // Ensure that the given expression type match the current expression
            // If not, the evaluation can't be performed
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
