namespace ProductionRuleSystem.Core.Rules
{
    public class RuleActionResult
    {
        public RuleActionResult(object data)
        {
            Data = data;
        }

        public object Data { get; }

        public bool Infered => false;
    }
}
