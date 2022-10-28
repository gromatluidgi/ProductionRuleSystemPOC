using System;

namespace BehavioralCriterias.Core.Ast
{
    public class Statement
    {
        protected string _variable;
        protected string _value;

        public string Condition { get; protected set; } = "=";

        public String Variable
        {
            get { return _variable; }
        }

        public string Value
        {
            get { return _value; }
        }

        public Statement(string variable, string value)
        {
            _variable = variable;
            _value = value;
        }

        public Statement(string variable, string condition, string value)
        {
            _variable = variable;
            _value = value;
            Condition = condition;
        }


        public IntersectionType MatchClause(Statement rhs)
        {
            if (_variable != rhs.Variable)
            {
                return IntersectionType.UNKNOWN;
            }

            return Intersect(rhs);
        }

        protected virtual IntersectionType Intersect(Statement rhs)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return _variable + " " + Condition + " " + _value;
        }
    }
}
