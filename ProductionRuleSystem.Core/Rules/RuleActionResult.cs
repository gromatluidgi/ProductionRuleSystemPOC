using System;
using System.Collections.Generic;
using System.Text;

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
