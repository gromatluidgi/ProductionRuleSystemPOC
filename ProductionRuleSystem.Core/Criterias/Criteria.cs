using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralCriterias.Core.Criterias
{
    public abstract class Criteria : ICriteria
    {
        protected Criteria(CriteriaCondition item)
        {

        }

        /// <summary>
        /// The unique name of the criteria that is used to identify
        /// </summary>
        public abstract string Token { get; }

        public abstract bool Evaluate<T>(T context);
    }
}
