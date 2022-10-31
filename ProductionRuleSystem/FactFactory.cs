using BehavioralCriterias.Domain;
using ProductionRuleSystem.Core.Facts;
using System;
using System.Collections.Generic;

namespace ProductionRuleSystem
{
    public class FactFactory : IFactFactory
    {
        public Fact? From<T>(T domainObject) where T : class
        {
            if (domainObject == null) throw new ArgumentNullException(nameof(domainObject));

            if (domainObject is Fact) return domainObject as Fact;

            if (domainObject is Issue) return FromIssue(domainObject as Issue);

            throw new NotImplementedException();
        }

        protected Fact FromIssue(Issue? issue)
        {
            if (issue == null) throw new ArgumentNullException(nameof(issue));
            return new Fact("Issue", issue.Id.ToString(), new List<FactAttribute>()
            {
                new FactAttribute("state", issue.State),
            });
        }
    }
}
