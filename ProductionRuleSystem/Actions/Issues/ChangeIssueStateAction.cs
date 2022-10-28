using BehavioralCriterias.Core.Rules;
using BehavioralCriterias.Domain;
using ProductionRuleSystem.Core;
using ProductionRuleSystem.Core.Rules;
using System.Linq;

namespace ProductionRuleSystem.Actions.Issues
{
    public class ChangeIssueStateAction : RuleAction
    {
        public ChangeIssueStateAction(string variable, string value) : base(variable, value)
        {
        }

        public override RuleActionResult Execute(IWorkingMemory workingMemory) 
        {
            Issue issue = (Issue)workingMemory.GetFacts(Variable).First().Context;
            issue.State = Value;
            return new RuleActionResult(issue);
        }
    }
}
