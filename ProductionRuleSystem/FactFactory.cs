using BehavioralCriterias.Domain;
using ProductionRuleSystem.Core.Ast;
using System;

namespace ProductionRuleSystem
{
    public class FactFactory : IFactFactory
    {
        public Fact From<T>(T domainObject)
        {
            if (domainObject == null) throw new Exception();

            if (domainObject is Fact) return domainObject as Fact;

            if (domainObject is Issue) return FromIssue(domainObject as Issue);

            throw new System.NotImplementedException();
        }

        protected Fact FromIssue(Issue issue)
        {
            return new Fact("", "", issue);
        }
    }
}
