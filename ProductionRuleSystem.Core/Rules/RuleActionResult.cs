namespace ProductionRuleSystem.Core.Rules
{
    public class RuleActionResult
    {
        public RuleActionResult(object data, bool infered = false)
        {
            Data = data;
            Infered = infered;
        }

        public object Data { get; }

        public bool Infered { get; }
    }
}
